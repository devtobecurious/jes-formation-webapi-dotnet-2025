using Microsoft.Extensions.Configuration;

namespace DTBC.Core.Web.API
{
	public class CSVConfigurationProvider(string filePath) : ConfigurationProvider
	{
		private Dictionary<string, string> keyValuePairs = new();

		public override void Load()
		{
			var lines = File.ReadAllLines(filePath);
			foreach (var line in lines)
			{
				var columns = line.Split(',');
				foreach (var column in columns)
				{
					keyValuePairs[column] = column;
				}
			}
		}
	}
}
