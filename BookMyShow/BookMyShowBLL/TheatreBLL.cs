using BookMyShowDAL;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL
{
    public class TheatreBLL
    {
        public static List<Theatre> movies;
        TheatreOperation theatreOperation = new TheatreOperation();
        public string AddTheatreBLL(Theatre theatre)
        {
            return theatreOperation.AddTheatre(theatre);
        }
        public string DeleteMovieBLL(int theatreId)
        {
            return theatreOperation.DeleteTheatre(theatreId);
        }
        public List<Theatre> ShowAllBLL()
        {
            return theatreOperation.ShowAll();
        }
        public string UpdateTheatreBLL(Theatre theatre)
        {
            return theatreOperation.UpdateTheatreDAL(theatre);
        }
    }
}
