using FlightBookingSystem_DAL.Configuration;
using FlightBookingSystem_DAL.DatabaseContext;
using FlightBookingSystem_DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<DonHangOffline> DonHangOfflines { get; set; }
        public virtual DbSet<DonHangKhuyenMai> DonHangKhuyenMais { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<SanBay> SanBays { get; set; }
        public virtual DbSet<TuyenBay> TuyenBays { get; set; }
        public virtual DbSet<HangMayBay> HangMayBays { get; set; }
        public virtual DbSet<MayBay> MayBays { get; set; }
        public virtual DbSet<ChuyenBay> ChuyenBays { get; set; }
        public virtual DbSet<SanBayTrungGian> SanBayTrungGians { get; set; }
        public virtual DbSet<LichBay> LichBays { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<HanhLy> HanhLys { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<ChiTietVe> ChiTietVes { get; set; }
        public virtual DbSet<GiaVeChuyenBay> GiaVeChuyenBays { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NguoiDungConfig());
            modelBuilder.ApplyConfiguration(new TaiKhoanConfig());
            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new NhanVienConfig());
            modelBuilder.ApplyConfiguration(new KhachHangConfig());
            modelBuilder.ApplyConfiguration(new KhuyenMaiConfig());
            modelBuilder.ApplyConfiguration(new DonHangConfig());
            modelBuilder.ApplyConfiguration(new DonHangKhuyenMaiConfig());
            modelBuilder.ApplyConfiguration(new DonHangOfflineConfig());
            modelBuilder.ApplyConfiguration(new ThanhToanConfig());
            modelBuilder.ApplyConfiguration(new KhuVucConfig());
            modelBuilder.ApplyConfiguration(new SanBayConfig());
            modelBuilder.ApplyConfiguration(new TuyenBayConfig());
            modelBuilder.ApplyConfiguration(new HangMayBayConfig());
            modelBuilder.ApplyConfiguration(new MayBayConfig());
            modelBuilder.ApplyConfiguration(new ChuyenBayConfig());
            modelBuilder.ApplyConfiguration(new SanBayTrungGianConfig());
            modelBuilder.ApplyConfiguration(new LichBayConfig());
            modelBuilder.ApplyConfiguration(new GheConfig());
            modelBuilder.ApplyConfiguration(new HanhLyConfig());
            modelBuilder.ApplyConfiguration(new VeConfig());
            modelBuilder.ApplyConfiguration(new ChiTietVeConfig());
            modelBuilder.ApplyConfiguration(new GiaVeChuyenBayConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-NK4SU1V\\SQLEXPRESS;Database=FlightBookingSystem;Trusted_Connection=True;Encrypt=false;");
            }
        }
    }
}
