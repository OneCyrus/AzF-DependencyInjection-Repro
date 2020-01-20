using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetWebAPI.Controllers
{
    [ApiController]
    [Route("api/inject")]
    public class Inject : ControllerBase
    {
        private readonly MD5DocumentHashProvider _demo;
        public Inject(MD5DocumentHashProvider shouldGetObject)
        {
            var _demo = shouldGetObject;
        }

        [HttpGet]
        public string Get()
        {
            return "still works";
        }
    }
}
