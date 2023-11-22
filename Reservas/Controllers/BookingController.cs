﻿using DB;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Reservas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public List<BookingDate> BookingDateAviable() => _bookingService.BookingDateAviableDb();

        [HttpPost]
        public bool AddReservation(BookingDate bookingDate) => _bookingService.BookingDateReservedDb(bookingDate);
    }
}
