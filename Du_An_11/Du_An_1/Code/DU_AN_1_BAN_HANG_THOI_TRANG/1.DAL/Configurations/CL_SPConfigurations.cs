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
    public class CL_SPConfigurations : IEntityTypeConfiguration<ChatLieu_SP>
    {
        public void Configure(EntityTypeBuilder<ChatLieu_SP> builder)
        {
            builder.ToTable("ChatLieu_SanPham");
            //builder.HasKey(x => new{x.IDCL,x.IDCTSP
            builder.HasKey(x => new { x.IDCTSP, x.IDCL });
            builder.Property(x => x.ChatLieuVai).IsRequired();
            builder.Property(x => x.TrangThai);
            builder.HasOne(x => x.chiTietSP).WithMany(x=>x.chatLieu_SPs).HasForeignKey(x => x.IDCTSP);
            builder.HasOne(x => x.ChatLieu).WithMany(x=>x.chatLieu_SPs).HasForeignKey(x => x.IDCL);
        }
    }
}
