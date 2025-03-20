using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Models
{
	public class VideoGame
	{
		#region Properties
		public int Id { get; set; }

		public required string Title { get; set; }

		private string description = string.Empty;
		public string Description 
		{ 
			get => description;
			set 
			{
				if(string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Description cannot be null or empty");
				}
				this.description = value;
			} 
				
		#endregion
	}
}
