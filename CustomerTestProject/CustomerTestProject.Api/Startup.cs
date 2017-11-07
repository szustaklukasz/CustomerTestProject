using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CustomerTestProject.DAL.Context;
using Microsoft.EntityFrameworkCore;
using CustomerTestProject.Infrastructure.Utility;
using CustomerTestProject.Infrastructure.Interface;
using CustomerTestProject.Infrastructure.DomainService;
using CustomerTestProject.DAL.Interface;
using CustomerTestProject.DAL.Repository;

namespace CustomerTestProject
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
            services.AddDbContext<DatabaseContext>(options =>
               options.UseSqlServer("Data Source=VEGUS-LAPTOP;Initial Catalog=CustomerTestProject;Integrated Security=True;Pooling=False"));
            services.AddScoped<ICustomerDomainService, CustomerDomainService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DatabaseContext context)
        {
            app.UseMvc();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            AutoMapperConfig.RegisterMappings();
        }
    }
}
