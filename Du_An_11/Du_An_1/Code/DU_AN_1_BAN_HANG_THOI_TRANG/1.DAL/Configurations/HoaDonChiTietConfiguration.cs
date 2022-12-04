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
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.ID);
            //builder.HasKey(x => new { x.IDHD, x.IDChiTietSP });
            builder.Property(x => x.SoLuong).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.DonGia).IsRequired();
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IDHD);
            builder.HasOne(x => x.ChiTietSP).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x => x.IDChiTietSP);
        }
    }
}
