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
    public class HanhLyConfig : IEntityTypeConfiguration<HanhLy>
    {
        public void Configure(EntityTypeBuilder<HanhLy> builder)
        {
            builder.ToTable("HanhLy");
            builder.HasKey(b => b.MaHL);
            builder.Property(b => b.TrongLuong).IsRequired();
            builder.Property(b => b.ChiPhi).IsRequired();
            builder.Property(b => b.MoTaHL).IsRequired(false);

            // Khoa ngoai HanhLy va ChiTietVe
            builder.HasOne(b => b.ChiTietVe)
                .WithOne(d => d.HanhLy)
                .HasForeignKey<ChiTietVe>(d => d.MaHL);
        }
    }
}
