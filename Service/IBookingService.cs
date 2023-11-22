using DB;

namespace Service
{
    public interface IBookingService
    {
        List<DateTime> BookingAviable();
        List<BookingDate> BookingDateAviableDb();
        bool BookingDateReservedDb(BookingDate booking);
    }
}
