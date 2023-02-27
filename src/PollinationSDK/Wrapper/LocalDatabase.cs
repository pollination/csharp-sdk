using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class LocalDatabase
    {
        private static SqliteConnection _connection;
        private static SqliteConnection connection { get
            {
                _connection = _connection ?? CreateConnection();
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();
                return _connection;
            } 
        }


        static SqliteConnection CreateConnection()
        {

            SqliteConnection con;
            var file = GetDatabaseFile();
            var fileExist = File.Exists(file);
            con = new SqliteConnection($"Data Source={file}");
            con.Open();
            if (!fileExist) InitDatabase();
            return con;
        }

        public static void DeleteDatabase()
        {
            var file = GetDatabaseFile();
            if (File.Exists(file))
                File.Delete(file);

        }
        public static string GetDatabaseFile()
        {
            var file = "database.db";
            //C:\Users\mingo\.pollination
            var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var dir = Path.Combine(userDir, ".pollination", file);
            return dir;
        }

        static void InitDatabase()
        {
            var con = connection;
            var cmd = con.CreateCommand();

            var createTable = "CREATE TABLE JobTable (DocID BLOB(36), JobID BLOB(36), DateTime TEXT, ResultPackage BLOB)";
            cmd.CommandText = createTable;
            cmd.ExecuteNonQuery();
        }

        public static bool Add(Guid docId, JobResultPackage resultPackage)
        {
            return Add(connection, docId, resultPackage);
        }
        public static List<JobResultPackage> Get(Guid docId)
        {
            return Get(connection, docId);
        }
        public static JobResultPackage Get(Guid docId, string jobID)
        {
            return Get(connection, docId, jobID).FirstOrDefault();
        }

        public static bool Delete(Guid docId, string jobID)
        {
            return Delete(connection, docId, jobID);
        }

        static bool Add(SqliteConnection connection, Guid docId, JobResultPackage resultPackage)
        {
            using (var con = connection)
            {
                var cmd = con.CreateCommand();

                cmd.CommandText =
    @"
    INSERT INTO JobTable (DocID, JobID, DateTime, ResultPackage)
    VALUES ($DocID, $JobID, $DateTime, $ResultPackage)
";
                cmd.Parameters.AddWithValue("$DocID", SqliteType.Blob).Value = docId;
                cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = resultPackage.JobID;
                cmd.Parameters.AddWithValue("$DateTime", SqliteType.Text).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("$ResultPackage", SqliteType.Blob).Value = resultPackage.Serialize_Binary();
                //cmd.Parameters.AddWithValue("$Recipe", resultPackage.Recipe);

                var done = cmd.ExecuteNonQuery();
                con.Close();
                return done == 1;
            }
    
            
        }

        static List<JobResultPackage> Get(SqliteConnection connection, Guid docId)
        {
            return Get(connection, docId, string.Empty);
        }
        static List<JobResultPackage> Get(SqliteConnection connection, Guid docId, string jobId)
        {
            var res = new List<JobResultPackage>();
            var condition = string.IsNullOrEmpty(jobId) ? "DocID = $DocID" : "DocID = $DocID AND JobID = $JobID";
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
$@"
    SELECT ResultPackage
    FROM JobTable
    WHERE {condition}
";
                cmd.Parameters.AddWithValue("$DocID", docId);
                cmd.Parameters.AddWithValue("$JobID", jobId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var package = (byte[])reader.GetValue(0);
                        var re = JobResultPackage.Deserialize_Binary(package);
                        res.Add(re);
                    }
                }
                con.Close();
            }
            return res;
        }

        static bool Delete(SqliteConnection connection, Guid docId, string jobId)
        {
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
@"
    DELETE
    FROM JobTable
    WHERE DocID = $DocID AND JobID = $JobID
";
                cmd.Parameters.AddWithValue("$DocID", SqliteType.Blob).Value = docId;
                cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = jobId;
               
                var done =  cmd.ExecuteNonQuery();
                con.Close();
                return done == 1;
            }
        }
    }
}
