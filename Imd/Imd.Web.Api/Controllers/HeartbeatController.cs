using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Imd.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class HeartbeatController : Controller
    {
        [HttpGet]
        public DateTime Get()
        {
            return DateTime.Now;
        }
    }
}
