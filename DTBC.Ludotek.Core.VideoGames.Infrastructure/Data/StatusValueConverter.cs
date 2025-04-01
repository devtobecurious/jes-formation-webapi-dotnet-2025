using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Infrastructure.Data
{
	internal class StatusValueConverter : ValueConverter<Status, string>
	{
		public StatusValueConverter() : base(
			v => v.ToString(),
			v => Enum.Parse<Status>(v))
		{
		}
	}
}
