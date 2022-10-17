using BookMyShowBLL.Services;
using BookMyShowEntity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MovieCoreAPI.Controllers
{
    //localhost:44543/api/Movies/GetMovies
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movieService.GetMovies();
        }
        [HttpGet("GetMoviesById")]
        public Movie GetMoviesById(int movieId)
        {
            return _movieService.GetMovieById(movieId);
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _movieService.AddMovie(movie);
            return Ok("Movie created successfully");
        }

        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int movieId)
        {
            _movieService.DeleteMovie(movieId);
            return Ok("Movie deleted successfully");
        }

        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            _movieService.UpdateMovie(movie);
            return Ok("Movie updated successfully");
        }
    }
}
