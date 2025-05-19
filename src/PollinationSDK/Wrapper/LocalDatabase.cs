
extern alias LBTNewtonsoft; extern alias LBTRestSharp; using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pollination;

namespace PollinationSDK.Wrapper
{
    public class LocalDatabase
    {
        private static Microsoft.Extensions.Logging.ILogger Logger => LogUtils.GetLogger<LocalDatabase>();

        public string DatabaseFile { get; set; } = "pollination.db";
        private SqliteConnection _connection;
        private SqliteConnection connection => GetConnection();

        private static LocalDatabase _instance;
        public static LocalDatabase Instance
        {
            get
            {
                _instance = (_instance ??= new LocalDatabase());
                return _instance;
            }
        }

        SqliteConnection GetConnection()
        {
            try
            {
                _connection = _connection ?? CreateConnection();
                if (_connection.State == System.Data.ConnectionState.Closed)
                    _connection.Open();
                return _connection;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                throw;
            }

        }

        SqliteConnection CreateConnection()
        {
            try
            {
                SqliteConnection con;
                var file = GetDatabaseFile();
                var fileExist = File.Exists(file);
                SQLitePCL.Batteries.Init();
                con = new SqliteConnection($"Data Source={file}");
                con.Open();
                Logger.Info($"ServerVersion: {con.ServerVersion}");
                if (!fileExist)
                    InitDatabase(con);

                return con;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                throw;
            }
           
        }

        public void DeleteDatabase()
        {
            var file = GetDatabaseFile();
            if (File.Exists(file))
                File.Delete(file);

        }

        public string GetDatabaseFile()
        {
            try
            {
                var file = DatabaseFile;
                //C:\Users\mingo\.pollination
                var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var dir = Path.Combine(userDir, ".pollination");
                Directory.CreateDirectory(dir);
                var filePath = Path.Combine(dir, file);
                Logger.Info(filePath);
                return filePath;
            }
            catch (Exception e)
            {
                Logger.Error(e);
                throw;
            }
      
        }

        static void InitDatabase(SqliteConnection con)
        {
            try
            {
                var cmd = con.CreateCommand();
                var createTable = "CREATE TABLE JobTable (ProjSlug BLOB(36), JobID BLOB(36), DateTime TEXT, JobInfo BLOB)";
                cmd.CommandText = createTable;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Logger.Error(e);
                throw;
            }

        }

     
        public bool Add(ScheduledJobInfo resultPackage)
        {
            return Add(connection, resultPackage);
        }
        
        public bool Add(List<ScheduledJobInfo> resultPackages)
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
        public List<ScheduledJobInfo> Get()
        {
            return Get(connection, string.Empty);
        }
      
        public List<ScheduledJobInfo> Get(string projSlug, bool reversedOrder = false, int count = 10)
        {
            var condition = $"ProjSlug = '{projSlug}'";
            if (reversedOrder)
                condition += " ORDER BY DateTime DESC";
            if (count > 0)
                condition += $" LIMIT {count}";

            return Get(connection, condition);
        }
        public ScheduledJobInfo Get(string projSlug, string jobID)
        {
            var condition = string.IsNullOrEmpty(jobID) ? $"ProjSlug = '{projSlug}'" : $"ProjSlug = '{projSlug}' AND JobID = '{jobID}'";
            return Get(connection, condition).FirstOrDefault();
        }

        public bool Delete(ScheduledJobInfo schJob)
        {
            return Delete(schJob.ProjectSlug, schJob.JobID);
        }

        public bool Delete(string projSlug, string jobID)
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
            try
            {
                using (var con = connection)
                {
                    var cmd = con.CreateCommand();
                    cmd.CommandText =
        @"
    INSERT INTO JobTable (ProjSlug, JobID, DateTime, JobInfo)
    VALUES ($ProjSlug, $JobID, $DateTime, $JobInfo)
";
                    cmd.Parameters.AddWithValue("$ProjSlug", SqliteType.Text).Value = schJob.ProjectSlug.ToLower();
                    cmd.Parameters.AddWithValue("$JobID", SqliteType.Text).Value = schJob.JobID;
                    cmd.Parameters.AddWithValue("$DateTime", SqliteType.Text).Value = DateTime.Now;
                    cmd.Parameters.AddWithValue("$JobInfo", SqliteType.Blob).Value = schJob.Serialize_Binary();
                    Logger.Info($"Adding {schJob.ProjectSlug}/{schJob.JobID}");
                    var done = cmd.ExecuteNonQuery();
                    con.Close();
                    return done == 1;
                }

            }
            catch (Exception e)
            {
                Logger.Error($"Failed to add job to local database:\n{schJob}" + "{e}", new[] { e });
                throw;
            }
           
        }

        static List<ScheduledJobInfo> Get(SqliteConnection connection, string condition)
        {

            try
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
                    Logger.Info($"Getting a job {condition}");
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
            catch (Exception e)
            {
                Logger.Error($"Failed to get a job from local database:\n{condition}" + "{e}", new[] { e });
                throw;
            }

        }

        static bool Delete(SqliteConnection connection, string projID, string jobId)
        {
            try
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
                    Logger.Info($"Deleting a job:\nProjSlug={projID} AND JobID={jobId}");
                    var done = cmd.ExecuteNonQuery();
                    con.Close();
                    return done >= 1;
                }
            }
            catch (Exception e)
            {

                Logger.Error($"Failed to delete a job from local database:\nProjSlug={projID} AND JobID={jobId}" + "{e}", new[] { e });
                throw;
            }
        
        }
    }
}
