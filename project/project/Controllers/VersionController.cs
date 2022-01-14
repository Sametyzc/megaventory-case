using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Controllers
{
    [ApiController]
    [Route("/")]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "API is working", $"version {GetType().Assembly.GetName().Version}" };
        }
    }
}
