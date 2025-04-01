using DTBC.Ludotek.Core.VideoGames.Models;
using DTBC.Ludotek.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Application.Commands
{
	public class AddVideoGameCommand(VideoGame item) : ICommand<VideoGame>
	{
		public Task Execute()
		{
			Console.WriteLine("Ah que c'est enregistré");

			return Task.FromResult(1);
		}
	}
}
