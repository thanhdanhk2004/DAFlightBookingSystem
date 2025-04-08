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
    public class SanBayConfig : IEntityTypeConfiguration<SanBay>
    {
        public void Configure(EntityTypeBuilder<SanBay> builder)
        {
            builder.ToTable("SanBay");
            builder.HasKey(a => a.MaSanBay);
            builder.Property(a => a.DiaDiem).IsRequired().HasMaxLength(50);
            builder.Property(a => a.MaKhuVuc).IsRequired();

            // Thiet lap khoai ngoai giua bang SanBay va bang KhuVuc
            builder.HasOne(a => a.KhuVuc)
                .WithMany(a => a.SanBays)
                .HasForeignKey(a => a.MaKhuVuc);

            //Thiet lap khoa ngoai giua bang SanBay va SanBayTrungIGna
            builder.HasOne(a => a.SanBayTrungGian)
                .WithOne(a => a.SanBay)
                .HasForeignKey<SanBayTrungGian>(a => a.MaSanBay)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
