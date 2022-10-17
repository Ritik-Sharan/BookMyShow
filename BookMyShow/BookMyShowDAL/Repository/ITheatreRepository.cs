using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface ITheatreRepository
    {
        void addTheatre(Theatre theatre);
        void updateTheatre(Theatre theatre);
        void deleteTheatre(int theatreId);
        Theatre getTheatreById(int theatreId);
        IEnumerable<Theatre> GetTheatres();
    }
}
