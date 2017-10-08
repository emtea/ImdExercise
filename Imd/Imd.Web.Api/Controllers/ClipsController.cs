using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Imd.Services.ShowReels.Interfaces;
using Imd.Domain.Models;
using Imd.Services.VideoClips.Interfaces;

namespace Imd.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClipsController : Controller
    {
        private IVideoClipsService videoClipsService;

        public ClipsController(IVideoClipsService videoClipsService)
        {
            this.videoClipsService = videoClipsService;
        }

        [HttpGet("{vs}/{vd}")]
        [ProducesResponseType(typeof(List<VideoClip>), 200)]
        public IActionResult Get(int vs, int vd)
        {
            var result = videoClipsService.RetrieveVideClips(vs, vd);

            return Ok(result);
        }
    }
}
