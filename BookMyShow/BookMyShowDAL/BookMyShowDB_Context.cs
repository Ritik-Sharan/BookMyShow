using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookMyShowDAL
{
    public class BookMyShowDB_Context : DbContext
    {
        public BookMyShowDB_Context(DbContextOptions<BookMyShowDB_Context> options) : base(options)
        {
        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Theatre> theatre { get; set; }
        public DbSet<ShowTiming> showTiming { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Booking> bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LLAP2298;Initial Catalog=BookMyShowDB;Integrated Security=True;");

        }
    }
}