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
    public class DonHangKhuyenMaiConfig : IEntityTypeConfiguration<DonHangKhuyenMai>
    {
        public void Configure(EntityTypeBuilder<DonHangKhuyenMai> builder)
        {
            builder.ToTable("DonHangKhuyenMai");
            builder.HasKey(o => o.MaDHKM);
            builder.Property(o => o.MaKM).IsRequired();

            //Thiet lap khoa ngoai tu bang DHOffline qua NhanVien
            builder.HasOne(o => o.KhuyenMai)
                .WithMany(e => e.DonHangKhuyenMais)
                .HasForeignKey(o => o.MaKM);
        }
    }
}
