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
    public class HinhThucThanhToanConfiguration : IEntityTypeConfiguration<HinhThucThanhToan>
    {
        public void Configure(EntityTypeBuilder<HinhThucThanhToan> builder)
        {
            builder.ToTable("HinhThucThanhToan");
            builder.HasKey(x => x.ID);
            //builder.Property(x => x.ID).UseIdentityColumn(1, 1);
            builder.Property(x => x.Ma).HasMaxLength(10);
            builder.Property(x => x.TrangThai);
        }
    }
}
