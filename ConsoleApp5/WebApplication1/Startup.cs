using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SoapCore;

namespace WebApplication1
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.TryAddSingleton<ISampleService, SampleService>();
            services.TryAddSingleton<ITissRecursoGlosaBinding, TissRecursoGlosaBinding>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();

            //app.UseSoapEndpoint<ISampleService>("/Service.svc", new BasicHttpBinding(), SoapSerializer.DataContractSerializer);
            //app.UseSoapEndpoint<ISampleService>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseSoapEndpoint<ITissRecursoGlosaBinding>("/Service.svc", new BasicHttpBinding(), SoapSerializer.DataContractSerializer);
            app.UseSoapEndpoint<ITissRecursoGlosaBinding>("/Service.asmx", new BasicHttpBinding(), SoapSerializer.XmlSerializer);
            app.UseMvc();
        }
    }
}
