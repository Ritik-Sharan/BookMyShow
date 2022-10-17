using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface IShowTimingRepository
    {
        void addShowTiming(ShowTiming showTiming);
        void updateShowTiming(ShowTiming showTiming);
        void deleteShowTiming(int showtimingId);
        ShowTiming getShowTimingById(int showtimingId);
        IEnumerable<ShowTiming> GetShowTimings();
    }
}
