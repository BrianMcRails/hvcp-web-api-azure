using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace hvcp_web_api
{
	using hvcp_web_api.Entities;
	using hvcp_web_api.Interfaces;
	using hvcp_web_api.Models;
	using hvcp_web_api.Repositories;

	using Microsoft.AspNetCore.Mvc.Formatters;
	using Microsoft.EntityFrameworkCore;

	public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
	        services.AddMvc();
			services.AddCors();

	        var connectionString = @"Server=tcp:hvcpwebapi.database.windows.net,1433;Database=hvcpwebapi;Uid=;Pwd=;Encrypt=yes;TrustServerCertificate=no;";
	        services.AddDbContext<StudyInfoContext>(o => o.UseSqlServer(connectionString));

	        services.AddScoped<IDemographicsRepository, DemographicsRepository>();
			services.AddScoped<IDicomstudiesRepository, DicomstudiesRepository>();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(this.Configuration.GetSection("Logging"));

            loggerFactory.AddDebug(LogLevel.Information);

			AutoMapper.Mapper.Initialize(
				cfg =>
					{
						cfg.CreateMap<Entities.Demographics, Models.DemographicDto>();
						cfg.CreateMap<Entities.Dicomstudies, Models.DicomstudyDto>();
						cfg.CreateMap<Entities.Dicomstudies, Models.DicomstudyWithChildrenDto>();
						cfg.CreateMap<Entities.Dicomseries, Models.DicomseriesDto>();
						cfg.CreateMap<Entities.Dicomimages, Models.DicomimageDto>();
					});
	        app.UseMvc();
        }
    }
}
