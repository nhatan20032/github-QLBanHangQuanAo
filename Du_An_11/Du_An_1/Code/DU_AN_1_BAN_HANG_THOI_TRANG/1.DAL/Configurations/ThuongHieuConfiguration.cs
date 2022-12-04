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
    public class ThuongHieuConfiguration : IEntityTypeConfiguration<ThuongHieu>
    {
        public void Configure(EntityTypeBuilder<ThuongHieu> builder)
        {
            builder.ToTable("ThuongHieu");
            builder.HasKey(x => x.ID);
            //builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Ma).HasMaxLength(10);
            builder.Property(x => x.Ten).HasMaxLength(200);
            builder.Property(x => x.TrangThai);
        }
    }
}
