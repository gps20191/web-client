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
            builder.Property(a => a.DataHoraRegistro).IsRequired();
            builder.Property(a => a.Estado).IsRequired();
            builder.Property(a => a.Latitude).IsRequired();
            builder.Property(a => a.Longitude).IsRequired();
            builder.Property(a => a.SuspeitoId).IsRequired();
            builder.Property(a => a.UrlFoto).IsRequired();
            builder.Property(a => a.Capturado).IsRequired();
        }
    }
}
