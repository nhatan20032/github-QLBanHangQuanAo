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
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.ID);
            //builder.Property(x => x.ID).UseIdentityColumn(1, 1);
            builder.Property(x => x.Ma).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Ho).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TenDem).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
            builder.Property(x => x.GioiTinh);
            builder.Property(x => x.Email);
            builder.Property(x => x.NgaySinh);
            builder.Property(x => x.CMND).IsRequired();
            builder.Property(x => x.SDT).IsRequired();
            builder.Property(x => x.DiaChi).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ThanhPho).IsRequired().HasMaxLength(200);
            builder.Property(x => x.QuocGia).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TrangThai);

            builder.HasOne(x => x.CuaHang).WithMany(x => x.NhanViens).HasForeignKey(x => x.IDCH);
            builder.HasOne(x => x.ChucVu).WithMany(x => x.NhanViens).HasForeignKey(x => x.IDCV);
            //builder.HasOne(x => x.NhanVienS).WithMany(x => x.NhanViens).HasForeignKey(x => x.IDGBC);
        }
    }
}
