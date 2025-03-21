using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Domains;
using Microsoft.Extensions.Options;

namespace DTBC.Ludotek.Core.Persons.Infrastructure.Queries
{
	public class GetDefaultPersonFromOptions(IOptions<Person> options) : IGetDefaultPerson
	{
		#region Public methods

		public Person Get()
		{
			return options.Value;
		}
		#endregion
	}
}
