using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Data.SqlClient;

namespace FlightBookingSystem_DAL.DatabaseContext
{
    public class TaiKhoanConfig : IEntityTypeConfiguration<TaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.ToTable("TaiKhoan");
            builder.HasKey(a => a.idTaiKhoan);
            builder.Property(a => a.idTaiKhoan).ValueGeneratedOnAdd();
            builder.Property(a => a.TenDangNhap).IsRequired().HasMaxLength(50);
            builder.HasIndex(a => a.TenDangNhap).IsUnique();
            builder.Property(a => a.TrangThai).HasDefaultValue(true);
            builder.Property(a => a.VaiTro).HasDefaultValue("User");
            builder.Property(a => a.IdNguoiDung).IsRequired();
        }
    }
}
