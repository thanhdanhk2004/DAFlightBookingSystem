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
    public class SanBayTrungGianConfig : IEntityTypeConfiguration<SanBayTrungGian>
    {
        public void Configure(EntityTypeBuilder<SanBayTrungGian> builder)
        {
            builder.ToTable("SanBayTrungGian");
            builder.HasKey(a => a.MaSanBayTrungGian);
            builder.Property(a => a.MaSanBay).IsRequired();
            builder.Property(a => a.MaChuyenBay).IsRequired();
            builder.Property(a => a.MaTuyenBay).IsRequired();
            builder.Property(a => a.ThoiGianDungChan).IsRequired();
            builder.Property(a => a.ThoiGianTiepTuc).IsRequired();

            // Khoa ngoai giua SanBayTrungGian va ChuyenBay
            builder.HasOne(a => a.ChuyenBay)
                .WithMany(f => f.SanBayTrungGians)
                .HasForeignKey(a => a.MaChuyenBay);
            
        }
    }
}
