using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface IMovieRepository
    {
        void addMovie(Movie movie);
        void updateMovie(Movie movie);
        void deleteMovie(int movieId);
        Movie getMovieById(int movieId);
        IEnumerable<Movie> GetMovies();

    }
}
