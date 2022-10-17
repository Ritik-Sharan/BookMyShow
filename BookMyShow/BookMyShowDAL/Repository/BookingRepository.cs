using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class BookingRepository : IBookingRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;

        public BookingRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addBooking(Booking booking)
        {
            _bookMyShowDB_Context.bookings.Add(booking);
            _bookMyShowDB_Context.SaveChanges();
        }

        public void deleteBooking(int bookingId)
        {
            var booking = _bookMyShowDB_Context.bookings.Find(bookingId);
            _bookMyShowDB_Context.bookings.Remove(booking);
            _bookMyShowDB_Context.SaveChanges();
        }

        public IEnumerable<Booking> GetBooking()
        {
            return _bookMyShowDB_Context.bookings.ToList();
        }

        public Booking getBookingById(int bookingId)
        {
            return _bookMyShowDB_Context.bookings.Find(bookingId);
        }

        public void updateBooking(Booking booking)
        {
            _bookMyShowDB_Context.Entry(booking).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
        }
    }
}
