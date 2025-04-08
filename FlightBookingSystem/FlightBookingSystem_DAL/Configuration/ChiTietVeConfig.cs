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
    public class ChiTietVeConfig : IEntityTypeConfiguration<ChiTietVe>
    {
        public void Configure(EntityTypeBuilder<ChiTietVe> builder)
        {
            builder.ToTable("ChiTietVe");
            builder.HasKey(t => t.MaChiTietVe);
            builder.Property(t => t.GiaVe).IsRequired();

            // Khoa ngoai ChiTieVe va Ve
            builder.HasOne(d => d.Ve)
                .WithMany(t => t.ChiTietVes)
                .HasForeignKey(d => d.MaVe)
                .OnDelete(DeleteBehavior.NoAction);

            // Khoa ngoai ChiTieVe va ChuyenBay
            builder.HasOne(d => d.ChuyenBay)
                .WithMany(f => f.ChiTietVes)
                .HasForeignKey(d => d.MaChuyenBay)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
