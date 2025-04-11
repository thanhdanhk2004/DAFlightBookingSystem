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
    public class VeConfig : IEntityTypeConfiguration<Ve>
    {
        public void Configure(EntityTypeBuilder<Ve> builder)
        {
            builder.ToTable("Ve");
            builder.HasKey(t => t.MaVe);
            builder.Property(t => t.LoaiVe).IsRequired();
            builder.Property(t => t.NgayXuatVe).HasDefaultValue(DateTime.Now);

            // Khoa ngoai Ve va DonHang
            builder.HasOne(t => t.DonHang)
                .WithMany(o => o.Ves)
                .HasForeignKey(t => t.MaDH)
                .OnDelete(DeleteBehavior.NoAction);

            // Khoa ngoai Ve va NguoiDung
            builder.HasOne(t => t.NguoiDung)
                .WithMany(u => u.Ves)
                .HasForeignKey(t => t.MaNguoiSoHuu)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
