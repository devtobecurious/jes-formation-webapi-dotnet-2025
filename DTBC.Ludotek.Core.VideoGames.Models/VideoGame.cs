using DTBC.Ludotek.Pipelines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Models
{
	public enum Status
	{
		Played = 10,
		Unplayed = 13,
		Playing = 14
	}

	//[Table("VideoGames")]
	public class VideoGame : IItem
	{
		#region Properties
		public int Id { get; set; }

		public required string Title { get; set; }

		public int Year { get; init; }

		public Status CurrentStatus { get; set; } = Status.Unplayed;

		//private string description = string.Empty;
		public string Description
		{
			get; // => description;
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Description cannot be null or empty");
				}
				field = value;
			}
		}

		public required Category MainCategory { get; set; }
		#endregion
	}
}
