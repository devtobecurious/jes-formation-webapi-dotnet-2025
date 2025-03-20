using DTBC.Ludotek.Core.VideoGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Application.Queries
{
	public interface IGetAllVideoGames
	{
		Task<IEnumerable<VideoGame>> GetAllAsync();
	}
}
