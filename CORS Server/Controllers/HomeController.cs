using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace cors_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("FetchValues")]
        [HttpGet]
        public IEnumerable<string> FetchValues()
        {
            return new string[] { "TestValue1", "TestValue2" };
        }
    }
}