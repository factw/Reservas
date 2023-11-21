namespace Service
{
    public class BookingService : IBookingService
    {
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
                    for (int hour = startHour; hour <= endHour - 4; hour+=4)
                    {
                        availableSlots.Add(new DateTime(date.Year, date.Month, date.Day, hour, 0, 0));
                    }
                }
            }

            return availableSlots;
        }

        private bool IsBussinesDay(DateTime date) =>  date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        
    }
}