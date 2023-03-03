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
            var dir = Path.Combine(userDir, ".pollination");
            Directory.CreateDirectory(dir);
            var filePath = Path.Combine(dir, file);
            return filePath;
        }

        static void InitDatabase()
        {
            var con = connection;
            var cmd = con.CreateCommand();

            var createTable = "CREATE TABLE JobTable (ProjSlug BLOB(36), JobID BLOB(36), DateTime TEXT, ResultPackage BLOB)";
            cmd.CommandText = createTable;
            cmd.ExecuteNonQuery();
        }

        public static bool Add(ScheduledJobInfo jobInfo)
        {
            return Add(new JobResultPackage(jobInfo));
        }

        public static bool Add(JobResultPackage resultPackage)
        {
            return Add(connection, resultPackage);
        }

        public static bool Add(List<JobResultPackage> resultPackages)
        {
            var done = true;
            foreach (var item in resultPackages)
            {
                done &= Add(item);
            }
            return done;
        }

        /// <summary>
        /// Get all JobResultPackage
        /// </summary>
        /// <returns></returns>
        public static List<JobResultPackage> Get()
        {
            return Get(connection, string.Empty);
        }
        public static List<JobResultPackage> Get(string projSlug)
        {
            var condition = $"ProjSlug = '{projSlug}'";
            return Get(connection, condition);
        }
        public static JobResultPackage Get(string projSlug, string jobID)
        {
            var condition = string.IsNullOrEmpty(jobID) ? $"ProjSlug = '{projSlug}'" : $"ProjSlug = '{projSlug}' AND JobID = '{jobID}'";
            return Get(connection, condition).FirstOrDefault();
        }

        public static bool Delete(JobResultPackage resultPackage)
        {
            return Delete(resultPackage.ProjectSlug, resultPackage.JobID);
        }

        public static bool Delete(string projID, string jobID)
        {
            return Delete(connection, projID, jobID);
        }

        static bool Add(SqliteConnection connection, JobResultPackage resultPackage)
        {
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
    @"
    INSERT INTO JobTable (ProjSlug, JobID, DateTime, ResultPackage)
    VALUES ($ProjSlug, $JobID, $DateTime, $ResultPackage)
";
                cmd.Parameters.AddWithValue("$ProjSlug", SqliteType.Text).Value = resultPackage.ProjectSlug;
                cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = resultPackage.JobID;
                cmd.Parameters.AddWithValue("$DateTime", SqliteType.Text).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("$ResultPackage", SqliteType.Blob).Value = resultPackage.Serialize_Binary();
                //cmd.Parameters.AddWithValue("$Recipe", resultPackage.Recipe);

                var done = cmd.ExecuteNonQuery();
                con.Close();
                return done == 1;
            }
            
        }

        static List<JobResultPackage> Get(SqliteConnection connection, string condition)
        {
            var res = new List<JobResultPackage>();
            condition = string.IsNullOrEmpty(condition) ? "1=1" : condition; 
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
$@"
    SELECT ResultPackage
    FROM JobTable
    WHERE {condition}
";
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

        static bool Delete(SqliteConnection connection, string projID, string jobId)
        {
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
@"
    DELETE
    FROM JobTable
    WHERE ProjSlug = $ProjSlug AND JobID = $JobID
";
                cmd.Parameters.AddWithValue("$ProjSlug", SqliteType.Blob).Value = projID;
                cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = jobId;
               
                var done =  cmd.ExecuteNonQuery();
                con.Close();
                return done == 1;
            }
        }
    }
}
