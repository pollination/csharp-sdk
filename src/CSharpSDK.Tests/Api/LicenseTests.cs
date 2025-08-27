using NUnit.Framework;
using System.IO;
using System.Linq;

namespace PollinationSDK.Test
{
    [TestFixture]
    public class LicenseTests
    {
        [Test]
        public void GetPoolsTest()
        {
            var api = new PollinationSDK.Api.LicensesApi();
            var pool = api.GetAvailablePools().Resources.Where(_ => _.Product == "rhino_plugin").FirstOrDefault();
            var id = pool.Id;
            Assert.IsNotNull(pool);
            Assert.IsNotNull(id);

            var license = api.GetPoolLicense(id);
            Assert.IsNotNull(license);
            Assert.IsTrue(!string.IsNullOrEmpty(license.Key));
        }

        [Test]
        public void GetLicenseKeyTest()
        {
            var key = Utilities.GetValidLicenseKey("rhino_plugin");
            Assert.IsTrue(!string.IsNullOrEmpty(key));
        }

        [Test]
        public void DeserializeLicense()
        {
            var f = Path.GetFullPath(@"../../../TestSample/licensePublic.json");
            var json = System.IO.File.ReadAllText(f);
            var l = LicensePublic.FromJson(json);
            Assert.IsNotNull(l);
        }
    }

}
