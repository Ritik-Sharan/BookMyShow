using BookMyShowDAL.Repository;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL.Services
{
    public class TheatreService
    {
        ITheatreRepository _theatreRepository;
        public TheatreService(ITheatreRepository theatreRepository)
        {
            _theatreRepository = theatreRepository;
        }

        //add theatre
        public void AddTheatre(Theatre theatre)
        {
            _theatreRepository.addTheatre(theatre);
        }
        //update theatre
        public void UpdateTheatre(Theatre theatre)
        {
            _theatreRepository.updateTheatre(theatre);
        }
        //delete theatre
        public void DeleteTheatre(int theatreId)
        {
            _theatreRepository.deleteTheatre(theatreId);
        }
        //gettheatrebyid theatre
        public Theatre GetTheatreById(int theatreId)
        {
            return _theatreRepository.getTheatreById(theatreId);
        }
        //get theatres
        public IEnumerable<Theatre> GetTheatres()
        {
            return _theatreRepository.GetTheatres();
        }
    }
}
