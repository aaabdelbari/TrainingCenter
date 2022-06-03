using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainingCenter.Application.Interfaces;
using TrainingCenter.Application.Mapping;
using TrainingCenter.Application.Services;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Infra.Data.Context;
using TrainingCenter.Infra.Data.Repository;

namespace TrainingCenter.Infra.IoC
{
	public static class DependencyContainer
	{
		public static IServiceCollection RegisterTrainingCenterServices(this IServiceCollection services, IConfiguration configuration)
		{
			// Application Layer
			services.AddScoped<ICourseService, CourseService>();


			// Infra.Data Layer
			services.AddScoped<ICourseRepository, CourseRepository>();


			services.AddDbContext<TrainingCenterDbContext>(options => {
				options.UseSqlServer(configuration.GetConnectionString("TrainingCenterDbConnection"));
			});

			services.AddAutoMapper(typeof(MappingProfile));

			return services;
		}
	}
}

