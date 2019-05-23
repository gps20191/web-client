using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Data.Interfaces;
using LookAtMe.Web.API.Data.Repository;
using LookAtMe.Web.API.Domain.Interfaces;
using LookAtMe.Web.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LookAtMe.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(
                //options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                options => options.UseSqlServer(Configuration.GetConnectionString("LocalConnection"))
            );

            services.AddScoped<IAlertaService, AlertaService>();            
            services.AddScoped<IAlertaRepository, AlertaRepository>();            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
