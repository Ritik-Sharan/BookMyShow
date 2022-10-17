using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL
{
    public class ShowTimingOperation
    {
        BookMyShowDB_Context db = null;

        public ShowTimingOperation()
        {
        }

        public ShowTimingOperation(BookMyShowDB_Context db)
        {
            this.db = db;
        }

        public string AddShowTiming(ShowTiming showTiming)
        {
            //db = new BookMyShowDB_Context();
            db.showTiming.Add(showTiming);
            db.SaveChanges();
            return "Added";
        }
        public string DeleteShowTiming(int Id)
        {
            //db = new BookMyShowDB_Context();
            ShowTiming showtimingobj = db.showTiming.Find(Id);
            db.Entry(showtimingobj).State = EntityState.Deleted;
            db.SaveChanges();
            return "Deleted";
        }
        public List<ShowTiming> ShowAll()
        {
            //db = new BookMyShowDB_Context();
            List<ShowTiming> showTimingList = db.showTiming.ToList();
            return showTimingList;
        }
        public string UpdateShowTimingDAL(ShowTiming showTiming)
        {
            //db = new BookMyShowDB_Context();
            db.Entry(showTiming).State = EntityState.Modified;
            db.SaveChanges();
            return "Updated";
        }
    }
}
