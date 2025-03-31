using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Pipelines
{
	public interface ICommand<T> where T : class, IItem
	{
		Task Execute();
	}
}
