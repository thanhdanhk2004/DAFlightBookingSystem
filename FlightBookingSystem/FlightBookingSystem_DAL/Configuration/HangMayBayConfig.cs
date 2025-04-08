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
    public class HangMayBayConfig : IEntityTypeConfiguration<HangMayBay>
    {
        public void Configure(EntityTypeBuilder<HangMayBay> builder)
        {
            builder.ToTable("HangHangKhong");
            builder.HasKey(a => a.SoHieuHang);
            builder.Property(a => a.TenHang).IsRequired().HasMaxLength(30);

        }
    }
}
