using Apimanager;
using Apimanager.Controllers;
using Apimanager.Implementations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiManager
{
    [TestClass]
    public class TesteDiffController
    { 
        private HttpClient _client { get; set; }

        public TesteDiffController()
        {
            var fixture = new WebApplicationFactory<Startup>();
            _client = fixture.CreateClient();

        }


        [TestMethod]
        public async Task TestResponseIndex()
        {
            var request = await _client.GetAsync("/v1/diff");
            //var indexresponse =response.Content.ReadAsStringAsync().Result;
            //var json = JsonConvert.DeserializeObject(a);
            Assert.IsTrue(request.StatusCode == HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task TestWithId()
        {
            var request = await _client.GetAsync("/v1/diff/11");
            Assert.IsTrue(request.StatusCode == HttpStatusCode.OK);
        }
                
        [TestMethod]
        public async Task TestJsonLeft()
        {
            var jsonContent = "{\"json\":\"data\"}";
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new
            MediaTypeHeaderValue("application/json");
            var request = await _client.PostAsync("/v1/diff/left", contentString);
            Assert.IsTrue(request.StatusCode == HttpStatusCode.OK);
        }

        [TestMethod]
        public async Task TestJsonRight()
        {
            var jsonContent = "{\"data\":\"data\"}";
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new
            MediaTypeHeaderValue("application/json");
            var request = await _client.PostAsync("/v1/diff/right?id=9", contentString);
            Assert.IsTrue(request.StatusCode == HttpStatusCode.OK);
        }
    }
}
