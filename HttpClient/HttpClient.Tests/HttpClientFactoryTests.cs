using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient;

namespace HttpClient.Tests
{
    [TestFixture]
    public class HttpClientFactoryTests
    {
        [Test]
        public void GetHttpClient_NoInputs_Returns_A_SystemNetHttpClient()
        {
            var factory = new HttpClientFactory();
            var client = factory.GetHttpClient();

            Assert.AreEqual(typeof(System.Net.Http.HttpClient), client.GetType())
;
        }

        [Test]
        public void GetHttpClient_NoInputs_Returns_TheSameInstance_SystemNetHttpClient()
        {
            var factory = new HttpClientFactory();

            var client1 = factory.GetHttpClient();
            var client1Hash = client1.GetHashCode();

            var client2 = factory.GetHttpClient();
            var client2Hash = client2.GetHashCode();

            Assert.AreEqual(client1Hash, client2Hash);
        }

        [Test]
        public void GetHttpClient_BaseUri_Returns_SystemNetHttpClientWithBaseAddress()
        {
            var testUri = "http://localhost/api/";
            var factory = new HttpClientFactory();

            var client = factory.GetHttpClient(testUri);

            Assert.AreEqual(client.BaseAddress, new Uri(testUri));
        }
    }
}
