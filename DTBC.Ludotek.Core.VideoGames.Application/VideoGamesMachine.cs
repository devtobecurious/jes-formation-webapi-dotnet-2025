using DTBC.Ludotek.Core.VideoGames.Application.Commands;
using DTBC.Ludotek.Core.VideoGames.Application.Queries;
using DTBC.Ludotek.Core.VideoGames.Models;
using DTBC.Ludotek.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Application
{
	public class VideoGamesMachine//(IGetAllVideoGames getAllVideoGames)
	{
		private static int Compteur = 0;
		private IGetAllVideoGames getAllVideoGames;
		private readonly Pipelines.Pipeline<VideoGame> pipeline = new ();

		public VideoGamesMachine(IGetAllVideoGames getAllVideoGames, PopCorn popCorn) //, string url) : this(getAllVideoGames)
		{
			this.getAllVideoGames = getAllVideoGames;
			popCorn.Manger();
			Compteur++;
		}

		#region Public methods
		public async Task<IEnumerable<VideoGames.Models.VideoGame>> GetAll()
		{
			var list = await this.getAllVideoGames.GetAllAsync();

			if(!list.Any())
			{
				throw new Exception("Required a non empty list");
			}

			return list;
		}

		public async Task Add(VideoGames.Models.VideoGame videoGame)
		{
			this.pipeline.Clear();
			this.pipeline.Add(new NodeVideoGameActions(new PrepareVideoGame(videoGame),
														 new AddVideoGameCommand(videoGame)));
			this.pipeline.Execute();
		}
		#endregion
	}
}
