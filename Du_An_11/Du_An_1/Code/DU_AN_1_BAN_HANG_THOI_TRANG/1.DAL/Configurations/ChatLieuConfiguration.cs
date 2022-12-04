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
    public class ChatLieuConfiguration : IEntityTypeConfiguration<ChatLieu>
    {
        public void Configure(EntityTypeBuilder<ChatLieu> builder)
        {
            builder.ToTable("ChatLieu");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ma).HasMaxLength(10);
            builder.Property(x => x.Ten).HasMaxLength(200);
            builder.Property(x => x.MoTa).HasMaxLength(200);
            builder.Property(x => x.TrangThai);
        }
    }
}
