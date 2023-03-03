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
            LocalDatabase.DeleteDatabase();
         
            var sampleData = Path.GetFullPath(@"../../../TestSample/LocalDatabase.json");
            var json = File.ReadAllText(sampleData);
            var jobs = ScheduledJobInfo.FromJsonArray(json);

            // test add
            foreach (var item in jobs)
            {
                var done = LocalDatabase.Add(item);
                Assert.IsTrue(done);
            }

            // test get all
            var getRes = LocalDatabase.Get();
            Assert.AreEqual(getRes.Count, 2);

            // test get one
            var firstRes = jobs.FirstOrDefault();
            var getOne = LocalDatabase.Get(firstRes.ProjectSlug, firstRes.JobID);
            Assert.AreEqual(getOne.Recipe, firstRes.Recipe);

            // test delete one
            var doneDel = LocalDatabase.Delete(firstRes);
            Assert.IsTrue(doneDel);
            getRes = LocalDatabase.Get();
            Assert.AreEqual(getRes.Count, 1);
        }
    }

}
