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
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma);
            //builder.Property(x => x.ID).UseIdentityColumn(1, 1);
            builder.Property(x => x.NgayTao);
            builder.Property(x => x.NgayThanhToan);
            builder.Property(x => x.ThanhTien);        
            builder.Property(x => x.GhiChu).HasMaxLength(200);
            builder.Property(x => x.TrangThai);
            builder.HasOne(x => x.KhachHang).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDKH);
            builder.HasOne(x => x.NhanVien).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDNV);
            builder.HasOne(x => x.HinhThucThanhToan).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDHTTT);
        }
    }
}
