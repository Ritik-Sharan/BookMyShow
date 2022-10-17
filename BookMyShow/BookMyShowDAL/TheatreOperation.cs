using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL
{
    public class TheatreOperation
    {
        BookMyShowDB_Context db = null;

        public TheatreOperation()
        {
        }

        public TheatreOperation(BookMyShowDB_Context db)
        {
            this.db = db;
        }

        public string AddTheatre(Theatre theatre)
        {
            //db = new BookMyShowDB_Context();
            db.theatre.Add(theatre);
            db.SaveChanges();
            return "Added";
        }
        public string DeleteTheatre(int theatreId)
        {
            //db = new BookMyShowDB_Context();
            Theatre theatreobj = db.theatre.Find(theatreId);
            db.Entry(theatreobj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<Theatre> ShowAll()
        {
            //db = new BookMyShowDB_Context();
            List<Theatre> theatreList = db.theatre.ToList();
            return theatreList;
        }
        public string UpdateTheatreDAL(Theatre theatre)
        {
            //db = new BookMyShowDB_Context();
            db.Entry(theatre).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }

    }
}
