using BookMyShowDAL.Repository;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL.Services
{
    public class ShowTimingService
    {
        IShowTimingRepository _showTimingRepository;
        public ShowTimingService(IShowTimingRepository showTimingRepository)
        {
            _showTimingRepository = showTimingRepository;
        }

        //add showtiming
        public void AddShowTiming(ShowTiming showTiming)
        {
            _showTimingRepository.addShowTiming(showTiming);
        }
        //update ShowTiming
        public void UpdateShowTiming(ShowTiming showTiming)
        {
            _showTimingRepository.updateShowTiming(showTiming);
        }
        //delete ShowTiming
        public void DeleteMovie(int showtimingId)
        {
            _showTimingRepository.deleteShowTiming(showtimingId);
        }
        //getShowTimingbyid ShowTiming
        public ShowTiming GetShowTimingById(int showtimingId)
        {
            return _showTimingRepository.getShowTimingById(showtimingId);
        }
        //get ShowTiming
        public IEnumerable<ShowTiming> GetShowTiming()
        {
            return _showTimingRepository.GetShowTimings();
        }
    }
}
