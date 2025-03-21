using DTBC.Ludotek.Core.Persons.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.Persons.Application.Queries
{
	public interface IGetDefaultPerson
	{
		Person Get();
	}
}
