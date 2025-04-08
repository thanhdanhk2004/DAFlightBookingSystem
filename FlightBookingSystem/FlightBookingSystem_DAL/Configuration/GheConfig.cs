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
    public class GheConfig : IEntityTypeConfiguration<Ghe>
    {
        public void Configure(EntityTypeBuilder<Ghe> builder)
        {
            builder.ToTable("Ghe");
            builder.HasKey(c => c.MaGhe);
            builder.Property(c => c.MaGhe).ValueGeneratedOnAdd();
            builder.Property(c => c.HangGhe).HasDefaultValue("PHOTHONG");
            builder.Property(c => c.TrangThaiGhe).HasDefaultValue("Còn trống");

            // Khoa ngoai Ghe va MayBay
            builder.HasOne(c => c.MayBay)
                .WithMany(p => p.Ghes)
                .HasForeignKey(c => c.SoHieuMB);

            // Khoa ngoai Ghe va ChiTietVie
            builder.HasOne(c => c.ChiTietVe)
                .WithOne(d => d.Ghe)
                .HasForeignKey<ChiTietVe>(d => d.MaGhe);
        }
    }
}
