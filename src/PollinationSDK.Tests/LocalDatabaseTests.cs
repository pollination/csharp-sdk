using NUnit.Framework;
using PollinationSDK.Wrapper;
using System;
using System.IO;
using System.Linq;

namespace PollinationSDK.Test
{
    [TestFixture]
    public class LocalDatabaseTests
    {
        [Test]
        public void LocalDataTest()
        {
            var db = new LocalDatabase();
            db.DatabaseFile = "test.db";
            db.DeleteDatabase();
         
            var sampleData = Path.GetFullPath(@"../../../TestSample/LocalDatabase.json");
            var json = File.ReadAllText(sampleData);
            var jobs = ScheduledJobInfo.FromJsonArray(json);

            // test add
            foreach (var item in jobs)
            {
                var done = db.Add(item);
                Assert.IsTrue(done);
            }

            // test get all
            var getRes = db.Get();
            Assert.AreEqual(getRes.Count, 2);

            // test get one
            var firstRes = jobs.FirstOrDefault();
            var getOne = db.Get(firstRes.ProjectSlug, firstRes.JobID);
            Assert.AreEqual(getOne.Recipe, firstRes.Recipe);

            // test delete one
            var doneDel = db.Delete(firstRes);
            Assert.IsTrue(doneDel);
            getRes = db.Get();
            Assert.AreEqual(getRes.Count, 1);
        }
    }

}
