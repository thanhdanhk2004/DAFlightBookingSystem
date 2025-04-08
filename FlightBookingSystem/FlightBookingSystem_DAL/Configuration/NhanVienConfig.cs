using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlightBookingSystem_DAL.Model;

namespace FlightBookingSystem_DAL.DatabaseContext
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(e => e.MaNV);
            builder.Property(e => e.Luong).IsRequired();
            builder.Property(e => e.NgayVaoLam).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(e => e.GhiChu).IsRequired(false);
        }
    }
}
