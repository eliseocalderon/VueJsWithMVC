using System;
using System.Web.Http;

namespace vueJsWithMVC.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok($"This is a new test message at {DateTime.Now}!");
        }
    }
}
