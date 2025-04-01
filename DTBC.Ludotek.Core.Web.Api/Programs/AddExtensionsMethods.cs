using DTBC.Ludotek.Core.Persons.Application;
using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Infrastructure.Queries;
using DTBC.Ludotek.Core.VideoGames.Application;
using DTBC.Ludotek.Core.VideoGames.Application.Queries;
using DTBC.Ludotek.Core.VideoGames.Infrastructure.Data;
using DTBC.Ludotek.Core.VideoGames.Infrastructure.InMemory;
using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DTBC.Ludotek.Core.Web.Api.Programs
{
	public static class AddExtensionsMethods
	{
		#region Public methods
		public static IServiceCollection AddInfrastructures(this IServiceCollection services, IConfiguration builder)
		{
			services.AddDbContext<VideoGamesDbContext>(options =>
			{
				options.UseMySQL(builder.GetConnectionString("VideoGames")!, options =>
				{
					options.CommandTimeout(60);
				});
				//options.UseInMemoryDatabase("VideoGames");
			});

#if DEBUG
			services.AddSingleton<IGetAllVideoGames, InMemoryGetAllVideoGames>();
#endif
			services.AddSingleton<IGetDefaultPerson, GetDefaultPersonFromOptions>();

			return services;
		}

		public static IServiceCollection AddApplications(this IServiceCollection services)
		{
			services.AddTransient<PopCorn>();
			services.AddScoped<VideoGamesMachine>(); // Dépendant de la requête
			services.AddScoped<PersonsMachine>();

			return services;
		}
		#endregion
	}
}
