using BookMyShowBLL.Services;
using BookMyShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatresController : ControllerBase
    {
        private TheatreService _theatreService;

        public TheatresController(TheatreService theatreService)
        {
            _theatreService = theatreService;
        }

        [HttpGet("GetTheatres")]
        public IEnumerable<Theatre> GetTheatres()
        {
            return _theatreService.GetTheatres();
        }
        [HttpGet("GetTheatresById")]
        public Theatre GetTheatresById(int theatreId)
        {
            return _theatreService.GetTheatreById(theatreId);
        }

        [HttpPost("AddTheatre")]
        public IActionResult AddTheatre([FromBody] Theatre theatre)
        {
            _theatreService.AddTheatre(theatre);
            return Ok("Theatre created successfully");
        }

        [HttpDelete("DeleteTheatre")]
        public IActionResult DeleteTheatre(int theatreId)
        {
            _theatreService.DeleteTheatre(theatreId);
            return Ok("Theatre deleted successfully");
        }

        [HttpPut("UpdateTheatre")]
        public IActionResult UpdateTheatre([FromBody] Theatre theatre)
        {
            _theatreService.UpdateTheatre(theatre);
            return Ok("Theatre updated successfully");
        }
    }
}
