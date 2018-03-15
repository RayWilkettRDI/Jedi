using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Jedi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Jedi.Service
{
    public class Startup
    {
        public IConfiguration _config;
        private readonly IHostingEnvironment _env;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            this._config = config;
            this._env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(IISDefaults.AuthenticationScheme);

            services.AddDbContext<PdmContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("PdmConnectionString"));
            });

            services.AddMvc(opt =>
            {
                if (_env.IsProduction())
                {
                    opt.Filters.Add(new RequireHttpsAttribute());
                }
            }).AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<IGsmRepository, GsmRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default", "{controller}/{action}/{id?}",
                    new { controller = "App", Action = "Index" });
            });

        }
    }
}
