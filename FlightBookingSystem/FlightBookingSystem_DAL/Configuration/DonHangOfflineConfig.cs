using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.DatabaseContext
{
    public class DonHangOfflineConfig : IEntityTypeConfiguration<DonHangOffline>
    {
        public void Configure(EntityTypeBuilder<DonHangOffline> builder)
        {
            builder.ToTable("DonHangOffline");
            builder.HasKey(o => o.MaDHOffline);
            builder.Property(o => o.MaNV).IsRequired();

            //Thiet lap khoa ngoai tu bang DHOffline qua NhanVien
            builder.HasOne(o => o.NhanVien)
                .WithMany(e => e.DonHangOfflines)
                .HasForeignKey(o => o.MaNV)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
