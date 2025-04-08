using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightBookingSystem_DAL.DatabaseContext
{
    public class NguoiDungConfig : IEntityTypeConfiguration<NguoiDung>
    {
        public void Configure(EntityTypeBuilder<NguoiDung> builder)
        {
            builder.ToTable("NguoiDung");
            builder.HasKey(u => u.IdNguoiDung);
            builder.Property(u => u.IdNguoiDung).ValueGeneratedOnAdd();
            builder.Property(u => u.Ho).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Ten).IsRequired().HasMaxLength(30);
            builder.Property(u => u.DiaChi).HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired(false).HasMaxLength(50);
            builder.Property(u => u.SoDienThoai).IsRequired(false).HasMaxLength(10);
            builder.Property(u => u.SoCCCD).IsRequired(false).HasMaxLength(12);
            builder.HasIndex(u => u.SoDienThoai).IsUnique();
            builder.HasIndex(u => u.SoCCCD).IsUnique();
            builder.Property(u => u.DiaChi).IsRequired(false);
            builder.Property(u => u.NgaySinh).HasDefaultValue(DateTime.Now);
            builder.Property(u => u.GioiTinh).IsRequired(false);

            //Thiêts lập khóa ngoại với tài khoản
            builder.HasOne(u => u.TaiKhoan)
                .WithOne(a => a.NguoiDung)
                .HasForeignKey<TaiKhoan>(a => a.IdNguoiDung);

            // thiet lap khao ngoai voi Admin
            builder.HasOne(u => u.Admin)
                .WithOne(a => a.NguoiDung)
                .HasForeignKey<Admin>(a => a.MaAdmin);

            // thiet lap khao ngoai voi KhachHang
            builder.HasOne(u => u.KhachHang)
                .WithOne(c => c.NguoiDung)
                .HasForeignKey<KhachHang>(a => a.MaKhachHang);

            // thiet lap khao ngoai voi NhanVien
            builder.HasOne(u => u.NhanVien)
                .WithOne(e => e.NguoiDung)
                .HasForeignKey<NhanVien>(e => e.MaNV);
        }
    }
}
