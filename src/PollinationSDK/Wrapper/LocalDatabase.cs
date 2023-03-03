using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PollinationSDK.Wrapper
{
    public class LocalDatabase
    {
        public static string DatabaseFile { get; set; } = "pollination.db";
        private static SqliteConnection _connection;
        private static SqliteConnection connection 
        { 
            get
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
            var file = DatabaseFile;
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

            var createTable = "CREATE TABLE JobTable (ProjSlug BLOB(36), JobID BLOB(36), DateTime TEXT, JobInfo BLOB)";
            cmd.CommandText = createTable;
            cmd.ExecuteNonQuery();
        }

     
        public static bool Add(ScheduledJobInfo resultPackage)
        {
            return Add(connection, resultPackage);
        }

        public static bool Add(List<ScheduledJobInfo> resultPackages)
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
        public static List<ScheduledJobInfo> Get()
        {
            return Get(connection, string.Empty);
        }
      
        public static List<ScheduledJobInfo> Get(string projSlug)
        {
            var condition = $"ProjSlug = '{projSlug}'";
            return Get(connection, condition);
        }
        public static ScheduledJobInfo Get(string projSlug, string jobID)
        {
            var condition = string.IsNullOrEmpty(jobID) ? $"ProjSlug = '{projSlug}'" : $"ProjSlug = '{projSlug}' AND JobID = '{jobID}'";
            return Get(connection, condition).FirstOrDefault();
        }

        public static bool Delete(ScheduledJobInfo schJob)
        {
            return Delete(schJob.ProjectSlug, schJob.JobID);
        }

        public static bool Delete(string projSlug, string jobID)
        {
            return Delete(connection, projSlug, jobID);
        }
        public bool Add(IEnumerable<ScheduledJobInfo> jobResults)
        {
            var done = true;
            foreach (var item in jobResults)
            {
                done &= Add(item);
            }
            return done;
        }

        static bool Add(SqliteConnection connection, ScheduledJobInfo schJob)
        {
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
    @"
    INSERT INTO JobTable (ProjSlug, JobID, DateTime, JobInfo)
    VALUES ($ProjSlug, $JobID, $DateTime, $JobInfo)
";
                cmd.Parameters.AddWithValue("$ProjSlug", SqliteType.Text).Value = schJob.ProjectSlug;
                cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = schJob.JobID;
                cmd.Parameters.AddWithValue("$DateTime", SqliteType.Text).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("$JobInfo", SqliteType.Blob).Value = schJob.Serialize_Binary();
                var done = cmd.ExecuteNonQuery();
                con.Close();
                return done == 1;
            }
            
        }

        static List<ScheduledJobInfo> Get(SqliteConnection connection, string condition)
        {
            var res = new List<ScheduledJobInfo>();
            condition = string.IsNullOrEmpty(condition) ? "1=1" : condition; 
            using (var con = connection)
            {
                var cmd = con.CreateCommand();
                cmd.CommandText =
$@"
    SELECT JobInfo
    FROM JobTable
    WHERE {condition}
";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var package = (byte[])reader.GetValue(0);
                        var re = ScheduledJobInfo.Deserialize_Binary(package);
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
                return done >= 1;
            }
        }
    }
}
