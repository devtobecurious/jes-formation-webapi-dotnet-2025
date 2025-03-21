using DTBC.Ludotek.Core.Persons.Application;
using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Domains;
using DTBC.Ludotek.Core.Persons.Infrastructure.Queries;
using DTBC.Ludotek.Core.VideoGames.Application;
using DTBC.Ludotek.Core.VideoGames.Application.Queries;
using DTBC.Ludotek.Core.VideoGames.Infrastructure.InMemory;
using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.Web.Api.Programs
{
	public static class AddExtensionsMethods
	{
		#region Public methods
		public static IServiceCollection AddInfrastructures(this IServiceCollection services)
		{
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
