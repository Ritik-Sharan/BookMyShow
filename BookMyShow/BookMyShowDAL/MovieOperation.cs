using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL
{
    public class MovieOperation
    {
        BookMyShowDB_Context db = null;

        public MovieOperation()
        {
        }

        public MovieOperation(BookMyShowDB_Context db)
        {
            this.db = db;
        }

        public string AddMovie(Movie movie)
        {
            //db = new BookMyShowDB_Context();
            db.movies.Add(movie);
            db.SaveChanges();
            return "Added";
        }
        public string DeleteMovie(int movieId)
        {
            //db = new BookMyShowDB_Context();
            Movie movieobj = db.movies.Find(movieId);
            db.Entry(movieobj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<Movie> ShowAll()
        {
            //db = new BookMyShowDB_Context();
            List<Movie> movieList = db.movies.ToList();
            return movieList;
        }
        public string UpdateMovieDAL(Movie movie)
        {
            //db = new BookMyShowDB_Context();
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";

        }
    }
}
