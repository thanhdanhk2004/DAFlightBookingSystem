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
    public class DonHangConfig : IEntityTypeConfiguration<DonHang>
    {
        public void Configure(EntityTypeBuilder<DonHang> builder)
        {
            builder.ToTable("DonHang");
            builder.HasKey(o => o.MaDH);
            builder.Property(o => o.NgayDatHang).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(o => o.TongGiaTriDonHang).IsRequired();
            builder.Property(o => o.MaKH).IsRequired();

            // Thiet lap khoa ngoai bang DonHang va bang KhachHang
            builder.HasOne(o => o.KhachHang)
                .WithMany(c => c.DonHangs)
                .HasForeignKey(o => o.MaKH);

            // Thiet lap khoa ngoai bang DonHang voi bang ThanhToan
            builder.HasOne(o => o.ThanhToan)
                .WithOne(p => p.DonHang)
                .HasForeignKey<ThanhToan>(p => p.MaDH);

            //Khoa ngoai DonHang va DonHangOFFline
            builder.HasOne(o => o.DonHangOffline)
                .WithOne(off => off.DonHang)
                .HasForeignKey<DonHangOffline>(off => off.MaDHOffline);

            //Khoa ngoai DonHang va DonHangKhuyenMai
            builder.HasOne(o => o.DonHangKhuyenMai)
                .WithOne(od => od.DonHang)
                .HasForeignKey<DonHangKhuyenMai>(od => od.MaDHKM);
        }
    }
}
