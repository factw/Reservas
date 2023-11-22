using DB;
using System.Collections.Generic;

namespace Repository
{
    public interface IBookingRepo
    {
        List<BookingDate> GetBookingDate();
        bool PostBookingDate(BookingDate booking);
    }
}
