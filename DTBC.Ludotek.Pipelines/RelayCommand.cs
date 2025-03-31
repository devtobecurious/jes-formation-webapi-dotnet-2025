using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Pipelines
{
	public delegate Task? ActionToExecute<T>(T sender, EventArgs e) where T: class, IItem;	

	public class RelayCommand<T>(T item, ActionToExecute<T> execute) : ICommand<T> where T : class, IItem
	{
		public Task? Execute()
		{
			return execute?.Invoke(item, EventArgs.Empty);
		}
	}
}
