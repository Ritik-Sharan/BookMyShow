using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class TheatreRepository : ITheatreRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;
        public TheatreRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addTheatre(Theatre theatre)
        {
            _bookMyShowDB_Context.theatre.Add(theatre);
            _bookMyShowDB_Context.SaveChanges();
        }
        public void deleteTheatre(int theatreId)
        {
            var theatre = _bookMyShowDB_Context.theatre.Find(theatreId);
            _bookMyShowDB_Context.theatre.Remove(theatre);
            _bookMyShowDB_Context.SaveChanges();
        }
        public Theatre getTheatreById(int theatreId)
        {
            return _bookMyShowDB_Context.theatre.Find(theatreId);
        }

        public IEnumerable<Theatre> GetTheatres()
        {
            return _bookMyShowDB_Context.theatre.ToList();
        }

        public void updateTheatre(Theatre theatre)
        {
            _bookMyShowDB_Context.Entry(theatre).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
        }
    }
}
