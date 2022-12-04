using _1.DAL.Configurations;
using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.ConText
{
    public class DUAN1DBContext : DbContext
    {
        public DUAN1DBContext()
        {
        }

        public DUAN1DBContext(DbContextOptions<DUAN1DBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new CuaHangConfiguration());
            modelBuilder.ApplyConfiguration(new ChatLieuConfiguration());
            modelBuilder.ApplyConfiguration(new SizeConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietSPConfiguration());
            modelBuilder.ApplyConfiguration(new MauSacConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ThuongHieuConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new HinhThucThanhToanConfiguration());
            modelBuilder.ApplyConfiguration(new DongSPConfiguration());
            modelBuilder.ApplyConfiguration(new CL_SPConfigurations());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            //modelBuilder.Seed(); //gọi cái này để seeding data
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=LAPTOP-8REJ154K;Initial Catalog=DuAn01;Persist Security Info=True; User ID =sa; Password =2003");
        }
        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<ChiTietSP> CTSanPhams { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<DongSP> DongSPs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Sizez> Sizes { get; set; }
        public virtual DbSet<HinhThucThanhToan> ThanhToans { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }
        public virtual DbSet<ChatLieu_SP> ChatLieu_SPs { get; set; }
    }
}
