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
    public class CuaHangConfiguration : IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.ToTable("CuaHang");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DiaChi).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ThanhPho).IsRequired().HasMaxLength(200);
            builder.Property(x => x.QuocGia).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TrangThai);
        }
    }
}
