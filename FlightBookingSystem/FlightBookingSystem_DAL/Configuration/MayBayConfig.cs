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
    public class MayBayConfig : IEntityTypeConfiguration<MayBay>
    {
        public void Configure(EntityTypeBuilder<MayBay> builder)
        {
            builder.ToTable("MayBay");
            builder.HasKey(p => p.SoHieuMB);
            builder.Property(p => p.SoHieuHang).IsRequired();

            // Thiet lap khoa ngoai giua HangMayBay va MayBay
            builder.HasOne(p => p.HangMayBay)
                .WithMany(a => a.MayBays)
                .HasForeignKey(p => p.SoHieuHang);
        }
    }
}
