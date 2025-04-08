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
    public class ChuyenBayConfig : IEntityTypeConfiguration<ChuyenBay>
    {
        public void Configure(EntityTypeBuilder<ChuyenBay> builder)
        {
            builder.ToTable("ChuyenBay");
            builder.HasKey(f => f.MaChuyenBay);
            builder.Property(f => f.ThoiGianDi).IsRequired();
            builder.Property(f => f.ThoiGianDen).IsRequired();
            builder.Property(f => f.SoHieuMB).IsRequired();

            // Thiet lap khoa ngoai giua MayBay va ChuyenBay
            builder.HasOne(f => f.MayBay)
                .WithMany(p => p.ChuyenBays)
                .HasForeignKey(f => f.SoHieuMB);

            //Thiet lap khoa ngoai giua ChuyenBay va LichBay
            builder.HasOne(f => f.LichBay)
                .WithOne(s => s.ChuyenBay)
                .HasForeignKey<LichBay>(s => s.MaChuyenBay);

            //Thiet lap khoa ngoai giua ChuyenBay va TuyenBay
            builder.HasOne(cb => cb.TuyenBay)
                .WithMany(tb => tb.ChuyenBays)
                .HasForeignKey(cb => cb.MaTuyenBay);
        }
    }
}
