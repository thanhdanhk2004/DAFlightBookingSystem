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
    public class LichBayConfig : IEntityTypeConfiguration<LichBay>
    {
        public void Configure(EntityTypeBuilder<LichBay> builder)
        {
            builder.ToTable("LichBay");
            builder.HasKey(s => s.MaLich);
            builder.Property(s => s.NgayLapLich).HasDefaultValue(DateTime.Now);

            // Khoa ngoai NhanVien va LichBay
            builder.HasOne(s => s.NhanVien)
                .WithMany(e => e.LichBays)
                .HasForeignKey(s => s.MaNV);
        }
    }
}
