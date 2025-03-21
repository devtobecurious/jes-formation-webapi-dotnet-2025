
using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Domains;

namespace DTBC.Ludotek.Core.Persons.Application
{
	public class PersonsMachine(IGetDefaultPerson getDefaultPerson)
	{
		public Person GetDefault()
		{
			return getDefaultPerson.Get();
		}
	}
}
