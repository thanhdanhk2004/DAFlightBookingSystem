using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.DatabaseContext
{
    public class KhuVucConfig : IEntityTypeConfiguration<KhuVuc>
    {
        public void Configure(EntityTypeBuilder<KhuVuc> builder)
        {
            builder.ToTable("KhuVuc");
            builder.HasKey(a => a.MaKhuVuc);
            builder.Property(a => a.TenKhuVuc).IsRequired().HasMaxLength(100);
        }
    }
}
