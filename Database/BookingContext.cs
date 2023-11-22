using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }

        public DbSet<BookingDate> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDate>().ToTable("Booking");
            modelBuilder.Entity<BookingDate>().HasData(
                new BookingDate { Id = 1, IsAviable = true, Reservation = DateTime.Parse("2023-11-21T08:00:00") },
                new BookingDate { Id = 2, IsAviable = true, Reservation = DateTime.Parse("2023-11-21T12:00:00") },
                new BookingDate { Id = 3, IsAviable = true, Reservation = DateTime.Parse("2023-11-21T16:00:00") },
                new BookingDate { Id = 4, IsAviable = true, Reservation = DateTime.Parse("2023-11-22T08:00:00") },
                new BookingDate { Id = 5, IsAviable = true, Reservation = DateTime.Parse("2023-11-22T12:00:00") },
                new BookingDate { Id = 6, IsAviable = true, Reservation = DateTime.Parse("2023-11-22T16:00:00") },
                new BookingDate { Id = 7, IsAviable = true, Reservation = DateTime.Parse("2023-11-23T08:00:00") },
                new BookingDate { Id = 8, IsAviable = true, Reservation = DateTime.Parse("2023-11-23T12:00:00") },
                new BookingDate { Id = 9, IsAviable = true, Reservation = DateTime.Parse("2023-11-23T16:00:00") },
                new BookingDate { Id = 10, IsAviable = true, Reservation = DateTime.Parse("2023-11-24T08:00:00") },
                new BookingDate { Id = 11, IsAviable = true, Reservation = DateTime.Parse("2023-11-24T12:00:00") },
                new BookingDate { Id = 12, IsAviable = true, Reservation = DateTime.Parse("2023-11-24T16:00:00") },
                new BookingDate { Id = 13, IsAviable = true, Reservation = DateTime.Parse("2023-11-27T08:00:00") },
                new BookingDate { Id = 14, IsAviable = true, Reservation = DateTime.Parse("2023-11-27T12:00:00") },
                new BookingDate { Id = 15, IsAviable = true, Reservation = DateTime.Parse("2023-11-27T16:00:00") },
                new BookingDate { Id = 16, IsAviable = true, Reservation = DateTime.Parse("2023-11-28T08:00:00") },
                new BookingDate { Id = 17, IsAviable = true, Reservation = DateTime.Parse("2023-11-28T12:00:00") },
                new BookingDate { Id = 18, IsAviable = true, Reservation = DateTime.Parse("2023-11-28T16:00:00") },
                new BookingDate { Id = 19, IsAviable = true, Reservation = DateTime.Parse("2023-11-29T08:00:00") },
                new BookingDate { Id = 20, IsAviable = true, Reservation = DateTime.Parse("2023-11-29T12:00:00") },
                new BookingDate { Id = 21, IsAviable = true, Reservation = DateTime.Parse("2023-11-29T16:00:00") },
                new BookingDate { Id = 22, IsAviable = true, Reservation = DateTime.Parse("2023-11-30T08:00:00") },
                new BookingDate { Id = 23, IsAviable = true, Reservation = DateTime.Parse("2023-11-30T12:00:00") },
                new BookingDate { Id = 24, IsAviable = true, Reservation = DateTime.Parse("2023-11-30T16:00:00") },
                new BookingDate { Id = 25, IsAviable = true, Reservation = DateTime.Parse("2023-12-01T08:00:00") },
                new BookingDate { Id = 26, IsAviable = true, Reservation = DateTime.Parse("2023-12-01T12:00:00") },
                new BookingDate { Id = 27, IsAviable = true, Reservation = DateTime.Parse("2023-12-01T16:00:00") },
                new BookingDate { Id = 28, IsAviable = true, Reservation = DateTime.Parse("2023-12-04T08:00:00") },
                new BookingDate { Id = 29, IsAviable = true, Reservation = DateTime.Parse("2023-12-04T12:00:00") },
                new BookingDate { Id = 30, IsAviable = true, Reservation = DateTime.Parse("2023-12-04T16:00:00") },
                new BookingDate { Id = 31, IsAviable = true, Reservation = DateTime.Parse("2023-12-05T08:00:00") },
                new BookingDate { Id = 32, IsAviable = true, Reservation = DateTime.Parse("2023-12-05T12:00:00") },
                new BookingDate { Id = 33, IsAviable = true, Reservation = DateTime.Parse("2023-12-05T16:00:00") },
                new BookingDate { Id = 34, IsAviable = true, Reservation = DateTime.Parse("2023-12-06T08:00:00") },
                new BookingDate { Id = 35, IsAviable = true, Reservation = DateTime.Parse("2023-12-06T12:00:00") },
                new BookingDate { Id = 36, IsAviable = true, Reservation = DateTime.Parse("2023-12-06T16:00:00") },
                new BookingDate { Id = 37, IsAviable = true, Reservation = DateTime.Parse("2023-12-07T08:00:00") },
                new BookingDate { Id = 38, IsAviable = true, Reservation = DateTime.Parse("2023-12-07T12:00:00") },
                new BookingDate { Id = 39, IsAviable = true, Reservation = DateTime.Parse("2023-12-07T16:00:00") },
                new BookingDate { Id = 40, IsAviable = true, Reservation = DateTime.Parse("2023-12-08T08:00:00") },
                new BookingDate { Id = 41, IsAviable = true, Reservation = DateTime.Parse("2023-12-08T12:00:00") },
                new BookingDate { Id = 42, IsAviable = true, Reservation = DateTime.Parse("2023-12-08T16:00:00") },
                new BookingDate { Id = 43, IsAviable = true, Reservation = DateTime.Parse("2023-12-11T08:00:00") },
                new BookingDate { Id = 44, IsAviable = true, Reservation = DateTime.Parse("2023-12-11T12:00:00") },
                new BookingDate { Id = 45, IsAviable = true, Reservation = DateTime.Parse("2023-12-11T16:00:00") },
                new BookingDate { Id = 46, IsAviable = true, Reservation = DateTime.Parse("2023-12-12T08:00:00") },
                new BookingDate { Id = 47, IsAviable = true, Reservation = DateTime.Parse("2023-12-12T12:00:00") },
                new BookingDate { Id = 48, IsAviable = true, Reservation = DateTime.Parse("2023-12-12T16:00:00") },
                new BookingDate { Id = 49, IsAviable = true, Reservation = DateTime.Parse("2023-12-13T08:00:00") },
                new BookingDate { Id = 50, IsAviable = true, Reservation = DateTime.Parse("2023-12-13T12:00:00") },
                new BookingDate { Id = 51, IsAviable = true, Reservation = DateTime.Parse("2023-12-13T16:00:00") },
                new BookingDate { Id = 52, IsAviable = true, Reservation = DateTime.Parse("2023-12-14T08:00:00") },
                new BookingDate { Id = 53, IsAviable = true, Reservation = DateTime.Parse("2023-12-14T12:00:00") },
                new BookingDate { Id = 54, IsAviable = true, Reservation = DateTime.Parse("2023-12-14T16:00:00") },
                new BookingDate { Id = 55, IsAviable = true, Reservation = DateTime.Parse("2023-12-15T08:00:00") },
                new BookingDate { Id = 56, IsAviable = true, Reservation = DateTime.Parse("2023-12-15T12:00:00") },
                new BookingDate { Id = 57, IsAviable = true, Reservation = DateTime.Parse("2023-12-15T16:00:00") },
                new BookingDate { Id = 58, IsAviable = true, Reservation = DateTime.Parse("2023-12-18T08:00:00") },
                new BookingDate { Id = 59, IsAviable = true, Reservation = DateTime.Parse("2023-12-18T12:00:00") },
                new BookingDate { Id = 60, IsAviable = true, Reservation = DateTime.Parse("2023-12-18T16:00:00") },
                new BookingDate { Id = 61, IsAviable = true, Reservation = DateTime.Parse("2023-12-19T08:00:00") },
                new BookingDate { Id = 62, IsAviable = true, Reservation = DateTime.Parse("2023-12-19T12:00:00") },
                new BookingDate { Id = 63, IsAviable = true, Reservation = DateTime.Parse("2023-12-19T16:00:00") },
                new BookingDate { Id = 64, IsAviable = true, Reservation = DateTime.Parse("2023-12-20T08:00:00") },
                new BookingDate { Id = 65, IsAviable = true, Reservation = DateTime.Parse("2023-12-20T12:00:00") },
                new BookingDate { Id = 66, IsAviable = true, Reservation = DateTime.Parse("2023-12-20T16:00:00") },
                new BookingDate { Id = 67, IsAviable = true, Reservation = DateTime.Parse("2023-12-21T08:00:00") },
                new BookingDate { Id = 68, IsAviable = true, Reservation = DateTime.Parse("2023-12-21T12:00:00") },
                new BookingDate { Id = 69, IsAviable = true, Reservation = DateTime.Parse("2023-12-21T16:00:00") },
                new BookingDate { Id = 70, IsAviable = true, Reservation = DateTime.Parse("2023-12-22T08:00:00") },
                new BookingDate { Id = 71, IsAviable = true, Reservation = DateTime.Parse("2023-12-22T12:00:00") },
                new BookingDate { Id = 72, IsAviable = true, Reservation = DateTime.Parse("2023-12-22T16:00:00") },
                new BookingDate { Id = 73, IsAviable = true, Reservation = DateTime.Parse("2023-12-25T08:00:00") },
                new BookingDate { Id = 74, IsAviable = true, Reservation = DateTime.Parse("2023-12-25T12:00:00") },
                new BookingDate { Id = 75, IsAviable = true, Reservation = DateTime.Parse("2023-12-25T16:00:00") });
        }

    }
}