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
    public class KhuyenMaiConfig : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(p => p.MaKM);
            builder.Property(p => p.TyLeGiam).IsRequired();
            builder.Property(p => p.NgayBatDau).IsRequired();
            builder.Property(p => p.NgayKetThuc).IsRequired();
            builder.Property(p => p.MoTa).IsRequired(false);
        }
    }
}
