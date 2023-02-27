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
            var res = JobResultPackage.FromJsonArray(json);

            // test add
            var docId = Guid.NewGuid(); // 
            foreach (var item in res)
            {
                var done = LocalDatabase.Add(docId, item);
                Assert.IsTrue(done);
            }

            // test get all
            var getRes = LocalDatabase.Get(docId);
            Assert.AreEqual(getRes.Count, 2);

            // test get one
            var firstRes = res.FirstOrDefault();
            var getOne = LocalDatabase.Get(docId, firstRes.JobID);
            Assert.AreEqual(getOne.Recipe, firstRes.Recipe);

            // test delete one
            var doneDel = LocalDatabase.Delete(docId, firstRes.JobID);
            Assert.IsTrue(doneDel);
            getRes = LocalDatabase.Get(docId);
            Assert.AreEqual(getRes.Count, 1);
        }
    }

}
