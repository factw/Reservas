using DB;
using Repository;

namespace Service
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepo _bookingRepo;
        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }
        public List<BookingDate> BookingDateAviableDb() => _bookingRepo.GetBookingDate();
        public bool BookingDateReservedDb(BookingDate booking)
        {
            var reservationList = _bookingRepo.GetBookingDate();
            var isAviable = reservationList.Where(re => re.Reservation.Equals(booking.Reservation)).Select(re => re.IsAviable).SingleOrDefault();
            if (!isAviable)
            {
                return false;
            }
            return _bookingRepo.PostBookingDate(booking);
        }
        public List<DateTime> BookingAviable()
        {

            DateTime startDate = new DateTime(2023, 11, 21);
            DateTime endDate = new DateTime(2023, 12, 25);
            int startHour = 8;
            int endHour = 20;

            return GenerateAvailableSlots(startDate, endDate, startHour, endHour);

        }


        private List<DateTime> GenerateAvailableSlots(DateTime startDate, DateTime endDate, int startHour, int endHour)
        {
            List<DateTime> availableSlots = new List<DateTime>();

            // Iterar a través de los días hábiles en el rango
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (IsBussinesDay(date))
                {
                    // Generar turnos horarios de una hora
                    for (int hour = startHour; hour <= endHour - 4; hour += 4)
                    {
                        availableSlots.Add(new DateTime(date.Year, date.Month, date.Day, hour, 0, 0));
                    }
                }
            }

            return availableSlots;
        }

        private bool IsBussinesDay(DateTime date) => date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;

    }
}