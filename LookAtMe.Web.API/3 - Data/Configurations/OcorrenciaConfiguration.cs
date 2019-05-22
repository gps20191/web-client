using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Data.Configurations
{
    public class OcorrenciaConfiguration : IEntityTypeConfiguration<Ocorrencia>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia> builder)
        {
            builder.ToTable(nameof(Ocorrencia));
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Descricao).IsRequired();
            builder.HasOne(o => o.Suspeito).WithMany(s => s.Ocorrencias).HasForeignKey(o => o.SuspeitoId);
        }
    }
}
