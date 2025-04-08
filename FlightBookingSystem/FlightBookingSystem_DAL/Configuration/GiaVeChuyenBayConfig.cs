using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Configuration
{
    public class GiaVeChuyenBayConfig : IEntityTypeConfiguration<GiaVeChuyenBay>
    {
        public void Configure(EntityTypeBuilder<GiaVeChuyenBay> builder)
        {
            builder.ToTable("GiaVeChuyenBay");
            builder.HasKey(p => p.MaHangGhe);
            builder.Property(p => p.MaCB).IsRequired();

            //Khoa ngoai giua GiaVeChuyenBay va ChuyenBay
            builder.HasOne(p => p.ChuyenBay)
                .WithMany(f => f.GiaVeChuyenBays)
                .HasForeignKey(p => p.MaCB)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
