namespace Model
{
    public class BookingDateResponse
    {
        public int Id { get; set; }
        public DateTime Reservation { get; set; }
        public bool IsAviable { get; set; }
    }
}