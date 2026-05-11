using Am.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(p => p.Passengers)
                   .WithMany(p => p.Flights)
                   .UsingEntity(j => j.ToTable("Reservations"));
            builder.HasOne(p => p.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey(p => p.PlaneFk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
