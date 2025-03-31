using DTBC.Ludotek.Core.VideoGames.Models;
using DTBC.Ludotek.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Application.Commands
{
	internal class NodeVideoGameActions(params List<ICommand<VideoGame>> commands) : ICommand<VideoGame>
	{
		public void Execute()
		{
			commands.ForEach(cmd => cmd.Execute());
		}
	}
}