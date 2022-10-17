using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class ShowTimingRepository : IShowTimingRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;
        public ShowTimingRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addShowTiming(ShowTiming showTiming)
        {
            _bookMyShowDB_Context.showTiming.Add(showTiming);
            _bookMyShowDB_Context.SaveChanges();
        }

        public void deleteShowTiming(int showtimingId)
        {
            var showTiming = _bookMyShowDB_Context.showTiming.Find(showtimingId);
            _bookMyShowDB_Context.showTiming.Remove(showTiming);
            _bookMyShowDB_Context.SaveChanges();
        }

        public ShowTiming getShowTimingById(int showtimingId)
        {
            return _bookMyShowDB_Context.showTiming.Find(showtimingId);
        }

        public IEnumerable<ShowTiming> GetShowTimings()
        {
            return _bookMyShowDB_Context.showTiming.ToList();
        }

        public void updateShowTiming(ShowTiming showTiming)
        {
            _bookMyShowDB_Context.Entry(showTiming).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
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
