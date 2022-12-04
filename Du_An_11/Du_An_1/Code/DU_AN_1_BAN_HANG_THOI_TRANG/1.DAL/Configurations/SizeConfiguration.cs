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
    public class SizeConfiguration : IEntityTypeConfiguration<Sizez>
    {
        public void Configure(EntityTypeBuilder<Sizez> builder)
        {
            builder.ToTable("Size");
            builder.HasKey(x => x.ID);
            //builder.Property(x => x.ID).UseIdentityColumn();
            builder.Property(x => x.Ma).HasMaxLength(10);
            builder.Property(x => x.Ten).HasMaxLength(200);
            builder.Property(x => x.MoTa).HasMaxLength(200);
            builder.Property(x => x.TrangThai);
        }
    }
}
