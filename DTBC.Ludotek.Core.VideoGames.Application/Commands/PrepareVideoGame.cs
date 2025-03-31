using DTBC.Ludotek.Core.VideoGames.Models;
using DTBC.Ludotek.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Application.Commands
{
	internal class PrepareVideoGame(VideoGame item) : ICommand<VideoGame>
	{
		public void Execute()
		{
			item.Description = "Je suis prêt";

			Console.WriteLine($"Je prépare : {item.Id}");
		}
	}
}
