using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Data.Configurations
{
    public class SuspeitoConfiguration : IEntityTypeConfiguration<Suspeito>
    {
        public void Configure(EntityTypeBuilder<Suspeito> builder)
        {
            builder.ToTable(nameof(Suspeito));
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Foto).IsRequired();
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
