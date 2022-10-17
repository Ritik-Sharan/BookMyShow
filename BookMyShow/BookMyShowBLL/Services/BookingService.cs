using BookMyShowDAL.Repository;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL.Services
{
    public class BookingService
    {
        IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        //add booking
        public void AddBooking(Booking booking)
        {
            _bookingRepository.addBooking(booking);
        }
        //update booking
        public void UpdateBooking(Booking booking)
        {
            _bookingRepository.updateBooking(booking);
        }
        //delete booking
        public void DeleteBooking(int bookingId)
        {
            _bookingRepository.deleteBooking(bookingId);
        }
        //getbookingbyid booking
        public Booking GetBookingById(int bookingId)
        {
           return _bookingRepository.getBookingById(bookingId);
        }
        //get bookings
        public IEnumerable<Booking> GetBookings()
        {
            return _bookingRepository.GetBooking();
        }
    }
}
