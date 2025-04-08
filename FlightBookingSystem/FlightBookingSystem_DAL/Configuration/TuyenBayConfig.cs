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
    public class TuyenBayConfig : IEntityTypeConfiguration<TuyenBay>
    {
        public void Configure(EntityTypeBuilder<TuyenBay> builder)
        {
            builder.ToTable("TuyenBay");
            builder.HasKey(f => f.MaTuyenBay);
            builder.Property(f => f.MaTuyenBay).HasMaxLength(10);
            builder.Property(f => f.MaSanBayDi).IsRequired();
            builder.Property(f => f.MaSanBayDen).IsRequired();
            
            // Thiet lap khoa ngoai giua TuyenBay va SanBayDi
            builder.HasOne(f => f.SanBayDi)
                .WithMany(a => a.TuyenBayDis)
                .HasForeignKey(f => f.MaSanBayDi)
                .OnDelete(DeleteBehavior.NoAction);

            // Thiet lap khoa ngoai giua TuyenBay va SanBayDen
            builder.HasOne(f => f.SanBayDen)
                .WithMany(a => a.TuyenBayDens)
                .HasForeignKey(f => f.MaSanBayDen)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
