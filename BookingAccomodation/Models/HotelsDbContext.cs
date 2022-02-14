using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingAccomodation.Models
{
    public class HotelsDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }


        public HotelsDbContext(DbContextOptions<HotelsDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
        }
    }
}
