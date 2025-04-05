using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Data.Configurations
{
    internal class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p=>p.MyFullName,
               owned =>
               {
                   owned.Property(owned => owned.FirstName).HasMaxLength(30)
               .HasColumnName("Name");
                   owned.Property(owned => owned.LastName).IsRequired();
               });
        }
    }
}
