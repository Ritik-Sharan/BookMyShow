using System;
using System.Collections.Generic;
using BookMyShowEntity;
using BookMyShowDAL;

namespace BookMyShowBLL
{
    public class MovieBLL
    {
        MovieOperation movieOperation = new MovieOperation();
        public string AddMovieBLL(Movie movie)
        {
            return movieOperation.AddMovie(movie);
        }
        public string DeleteMovieBLL(int movieId)
        {
            return movieOperation.DeleteMovie(movieId);
        }
        public List<Movie> ShowAllBLL()
        {
            return movieOperation.ShowAll();
        }
        public string UpdateMovieBLL(Movie movie)
        {
            return movieOperation.UpdateMovieDAL(movie);
        }
    }
}
