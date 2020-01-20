using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DemoClass;

namespace AzureFunctions
{
    public class Inject
    {
        public Inject(MD5DocumentHashProvider shouldGetObject)
        {
            // this should return null and not throw an exception
            var _shouldBeNull = shouldGetObject;
        }

        [FunctionName("Inject")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            return (ActionResult)new OkObjectResult($"cannot send this");
        }
    }
}
