using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTBC.Ludotek.Core.VideoGames.Models
{
	public class VideoGameStatusValueObject
	{
		public static VideoGameStatusValueObject NotRead = new VideoGameStatusValueObject(1, "Not read");
		public static VideoGameStatusValueObject Running = new VideoGameStatusValueObject(2, "Running");
		public static VideoGameStatusValueObject Finished = new VideoGameStatusValueObject(3, "Finished");

		private VideoGameStatusValueObject() { }

		public VideoGameStatusValueObject(int id, string label) : this()
		{
			Id = id;
			Label = label;
		}
		public static bool operator ==(VideoGameStatusValueObject a, VideoGameStatusValueObject b) => a.Id == b.Id;
		public static bool operator !=(VideoGameStatusValueObject a, VideoGameStatusValueObject b) => a.Id != b.Id;

		public int Id { get; }
		public string Label { get; } = string.Empty;
	}

	public record VideoGameStatusRecord(int Id, string Title);
}
