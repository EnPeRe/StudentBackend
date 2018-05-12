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
using Microsoft.Net.Http.Headers;
using StudentBackend.Business.Logic;
using StudentBackend.Business.Logic.Contracts;
using StudentBackend.Common.Logic;
using StudentBackend.Common.Logic.Contracts;
using StudentBackend.Repository.Logic;
using StudentBackend.Repository.Logic.Contracts;
using StudentBackend.Repository.Logic.DataBaseContext;

namespace StudentBackend.Business.Facade
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
            services.AddTransient<IStudentBusinessLogic, StudentBusinessLogic>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<StudentContext, StudentContext>();
            services.AddTransient<IMyLog, MyLog>();
            services.AddMvc(options =>
               {
                   options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/xml"));
                   options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
               })
                .AddXmlSerializerFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
