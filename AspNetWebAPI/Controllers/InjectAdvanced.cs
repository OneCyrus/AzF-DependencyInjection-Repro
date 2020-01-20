using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetWebAPI.Controllers
{
    [ApiController]
    [Route("api/injectAdv")]
    public class InjecAdv : ControllerBase
    {
        public InjecAdv(IHttpContextAccessor context)
        {
            // this returns null and doesn't throw an exception
            var _null = context.HttpContext.RequestServices.GetService<IUrlHelper>();

            // this should throw an exception
            var _exception = context.HttpContext.RequestServices.GetRequiredService<IUrlHelper>();
        }

        [HttpGet]
        public string Get()
        {
            return "still works";
        }
    }
}
