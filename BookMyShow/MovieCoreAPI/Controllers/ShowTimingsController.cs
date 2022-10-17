using BookMyShowBLL.Services;
using BookMyShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimingsController : ControllerBase
    {
        private ShowTimingService _showTimingService;

        public ShowTimingsController(ShowTimingService showTimingService)
        {
            _showTimingService = showTimingService;
        }

        [HttpGet("GetShowTimings")]
        public IEnumerable<ShowTiming> GetShowTimings()
        {
            return _showTimingService.GetShowTiming();
        }

        [HttpGet("GetShowTimingsById")]
        public ShowTiming GetShowTimingsById(int showtimingId)
        {
            return _showTimingService.GetShowTimingById(showtimingId);
        }

        [HttpPost("AddShowTiming")]
        public IActionResult AddShowTiming([FromBody] ShowTiming showTiming)
        {
            _showTimingService.AddShowTiming(showTiming);
            return Ok("ShowTiming created successfully");
        }

        [HttpDelete("DeleteShowTiming")]
        public IActionResult DeleteShowTiming(int showtimingId)
        {
            _showTimingService.DeleteMovie(showtimingId);
            return Ok("ShowTiming deleted successfully");
        }

        [HttpPut("UpdateShowTiming")]
        public IActionResult UpdateMovie([FromBody] ShowTiming showTiming)
        {
            _showTimingService.UpdateShowTiming(showTiming);
            return Ok("ShowTiming updated successfully");
        }
    }
}
