using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using AM.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{
   public class AMContext : DbContext

    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog = Airport_Class; 
                                          Integrated Security = true")
                .UseLazyLoadingProxies(); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Question 3
            //modelBuilder.Entity<Passenger>().ToTable("Passengers");
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");
            //modelBuilder.Entity<Staff>().ToTable("Staffs");

            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
            modelBuilder.ApplyConfiguration(new PassengerConfig());

            // Question 1/a,b,c

            modelBuilder.Entity<Passenger>()
               .HasDiscriminator<int>("IsTraveller")
               .HasValue<Traveller>(1)
               .HasValue<Staff>(2)
               .HasValue<Passenger>(0);


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

    }
}
