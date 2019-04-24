using LookAtMe.Web.API.Data.Configurations;
using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace LookAtMe.Web.API.Data.Context
{
    public class AppContext : DbContext
    {

        public DbSet<Alerta> Alertas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlertaConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
