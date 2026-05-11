using Am.ApplicationCore.Domaine;
using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        //Les Entités 
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        //Chaine de connexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTwin;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        override
            protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new planeConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            //Api_ConfigTPH
/*            modelBuilder.Entity <Passenger>()
                .HasDiscriminator<int>("PassengerType")
                .HasValue<Passenger>(0)
                .HasValue<Traveller>(1)
                .HasValue<Staff>(2);
  */
            //Api_ConfigTPT
            modelBuilder.Entity<Traveller>()
                .ToTable("Travellers");
            modelBuilder.Entity<Staff>()
                .ToTable("Staffs");
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            //           configurationBuilder.Properties<string>().HaveMaxLength(100);
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
        
        }









    }
}
