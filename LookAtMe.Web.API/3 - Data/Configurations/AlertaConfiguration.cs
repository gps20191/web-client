using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LookAtMe.Web.API.Data.Configurations
{
    public class AlertaConfiguration : IEntityTypeConfiguration<Alerta>
    {
        public void Configure(EntityTypeBuilder<Alerta> builder)
        {
            builder.ToTable(nameof(Alerta));
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Suspeito).WithMany().HasForeignKey(a => a.SuspeitoId);
            builder.Property(a => a.Localizacao).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Estado).HasMaxLength(15).IsRequired();
            builder.Property(a => a.LinhaTranscol).IsRequired();
            builder.Property(a => a.Capturado).IsRequired();
        }
    }
}
