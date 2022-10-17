using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class MovieRepository : IMovieRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;

        public MovieRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addMovie(Movie movie)
        {
            _bookMyShowDB_Context.movies.Add(movie);
            _bookMyShowDB_Context.SaveChanges();
        }

        public void deleteMovie(int movieId)
        {
            var movie = _bookMyShowDB_Context.movies.Find(movieId);
            _bookMyShowDB_Context.movies.Remove(movie);
            _bookMyShowDB_Context.SaveChanges();
        }

        public Movie getMovieById(int movieId)
        {
            return _bookMyShowDB_Context.movies.Find(movieId);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _bookMyShowDB_Context.movies.ToList();
        }

        public void updateMovie(Movie movie)
        {
            _bookMyShowDB_Context.Entry(movie).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
        }
    }
}