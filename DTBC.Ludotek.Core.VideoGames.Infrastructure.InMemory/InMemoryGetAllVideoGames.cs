using DTBC.Ludotek.Core.VideoGames.Application.Queries;
using DTBC.Ludotek.Core.VideoGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Infrastructure.InMemory
{
	public class InMemoryGetAllVideoGames : IGetAllVideoGames
	{
		private static int Compteur = 0;

		public InMemoryGetAllVideoGames()
		{
			Compteur++;	
		}

		public Task<IEnumerable<VideoGame>> GetAllAsync()
		{
			var list = new List<VideoGame>()
			{
				new () { Title = "Super Mario Bros", Year = 1985, Description = "The classic game of Mario" },
				new () { Title = "The Legend of Zelda", Year = 1986, Description = "The classic game of Link" },
				new () { Title = "Metroid", Year = 1986, Description = "The classic game of Samus" },
				new () { Title = "Castlevania", Year = 1986, Description = "The classic game of Simon" },
				new () { Title = "Kid Icarus", Year = 1986, Description = "The classic game of Pit" },
			};

			return Task.FromResult(list.AsEnumerable());
		}
	}
}
