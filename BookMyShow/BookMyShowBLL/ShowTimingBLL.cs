using BookMyShowDAL;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL
{
    public class ShowTimingBLL
    {
        public static List<ShowTiming> showTimings;
        ShowTimingOperation showTimingOperation = new ShowTimingOperation();
        public string AddShowTimingBLL(ShowTiming showTiming)
        {
            return showTimingOperation.AddShowTiming(showTiming);
        }
        public string DeleteShowTimingBLL(int Id)
        {
            return showTimingOperation.DeleteShowTiming(Id);
        }
        public List<ShowTiming> ShowShowTimingBLL()
        {
            return showTimingOperation.ShowAll();
        }
        public string UpdateShowTimingBLL(ShowTiming showTiming)
        {
            return showTimingOperation.UpdateShowTimingDAL(showTiming);
        }
    }
}
