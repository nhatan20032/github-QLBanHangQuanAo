using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class ChiTietSPConfiguration : IEntityTypeConfiguration<ChiTietSP>
    {
        public void Configure(EntityTypeBuilder<ChiTietSP> builder)
        {
            builder.ToTable("ChiTietSP");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SoLuongTon).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.GiaBan).IsRequired();
            builder.Property(x => x.GiaNhap).IsRequired();
            builder.Property(x => x.MoTa).IsRequired();
            builder.Property(x => x.Ma);
            builder.Property(x => x.AnhMoTa);
            builder.Property(x => x.TrangThai).IsRequired();
            builder.HasOne(t => t.ThuongHieu).WithMany(p => p.chiTietSPs).HasForeignKey(p => p.IDThuongHieu);
            builder.HasOne(t => t.DongSP).WithMany(p => p.chiTietSPs).HasForeignKey(p => p.IDDongSP);
            builder.HasOne(t => t.MauSac).WithMany(p => p.chiTietSPs).HasForeignKey(p => p.IDMauSac);
            builder.HasOne(t => t.Size).WithMany(p => p.chiTietSPs).HasForeignKey(p => p.IDSize);
            builder.HasOne(t => t.SanPham).WithMany(p => p.chiTietSPs).HasForeignKey(p => p.IDSP);
        }
    }
}
