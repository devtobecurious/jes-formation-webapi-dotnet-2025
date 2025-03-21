using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Core.Web.API
{
	public class CSVConfigurationSource(string filePath) : IConfigurationSource
	{
		public IConfigurationProvider Build(IConfigurationBuilder builder)
		{
			var root = builder.Build();

			// root[""]

			return new CSVConfigurationProvider(filePath);
		}
	}
}
