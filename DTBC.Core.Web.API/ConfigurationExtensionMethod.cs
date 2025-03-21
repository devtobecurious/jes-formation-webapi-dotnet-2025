using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Core.Web.API
{
	public static class ConfigurationExtensionMethod
	{
		public static IConfigurationBuilder AddCsvFile(this IConfigurationBuilder builder, string filePath)
		{
			//builder.Build().Providers.First().

			return builder.Add(new CSVConfigurationSource(filePath));
		}
	}
}
