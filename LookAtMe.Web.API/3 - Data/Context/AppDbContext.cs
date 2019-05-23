using LookAtMe.Web.API.Data.Configurations;
using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace LookAtMe.Web.API.Data.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Alerta> Alertas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlertaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}