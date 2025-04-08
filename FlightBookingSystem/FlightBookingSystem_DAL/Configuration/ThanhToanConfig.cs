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
    public class ThanhToanConfig : IEntityTypeConfiguration<ThanhToan>
    {
        public void Configure(EntityTypeBuilder<ThanhToan> builder)
        {
            builder.ToTable("ThanhToan");
            builder.HasKey(p => p.MaThanhToan);
            builder.Property(p => p.SoTien).IsRequired();
            builder.Property(p => p.NgayThanhToan).IsRequired()
                            .HasDefaultValue(DateTime.Now);
            builder.Property(p => p.PhuongThucThanhToan).IsRequired();
            builder.Property(p => p.MaDH).IsRequired();

            
        }
    }
}
