using DB;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class BookingRepo : IBookingRepo
    {
        private readonly BookingContext _bookingContext;

        public BookingRepo(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }

        public List<BookingDate> GetBookingDate() => _bookingContext.BookingTests.ToList();

        public bool PostBookingDate(BookingDate booking)
        {            
            _bookingContext.Update(booking);
            return _bookingContext.SaveChanges() != 0 ? true : false;
        }
    }
}