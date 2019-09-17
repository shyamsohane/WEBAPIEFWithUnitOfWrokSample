using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WepAPIPOCWithEF.Data;
using Threenine.Data.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIPOCWithEF
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string dbConnString = Configuration.GetConnectionString("SQLCeConnection");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<WebAPIPOCWithEFContext>(options =>
                options.UseSqlite(dbConnString, builder => builder.MigrationsAssembly(typeof(Startup).Assembly.FullName)
                )).AddUnitOfWork<WebAPIPOCWithEFContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //else
            //{
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
