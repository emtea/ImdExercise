using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Imd.Services.ShowReels.Interfaces;
using Imd.Domain.Models;

namespace Imd.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReelsController : Controller
    {
        private IShowReelsService showReelService;

        public ReelsController(IShowReelsService showReelService)
        {
            this.showReelService = showReelService;
        }

        [HttpGet]
        [Route("all")]
        [ProducesResponseType(typeof(List<ShowReel>), 200)]
        public IActionResult GetAll()
        {
            var result = showReelService.RetrieveReelsPerUser();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ShowReel), 200)]
        public IActionResult Get(Guid id)
        {
            ShowReel result = showReelService.RetrieveReel(id);

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ShowReel), 200)]
        public IActionResult Post(ShowReel showReel)
        {
            ShowReel result = showReelService.ReelUpsert(showReel);
            return Ok(result);
        }
    }
}
