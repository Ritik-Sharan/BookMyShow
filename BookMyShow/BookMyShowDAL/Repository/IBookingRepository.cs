using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface IBookingRepository
    {
        void addBooking(Booking booking);
        void updateBooking(Booking booking);
        void deleteBooking(int bookingId);
        Booking getBookingById(int bookingId);
        IEnumerable<Booking> GetBooking();
    }
}
