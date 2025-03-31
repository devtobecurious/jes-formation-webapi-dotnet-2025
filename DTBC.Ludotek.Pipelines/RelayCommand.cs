using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Pipelines
{
	public delegate void ActionToExecute<T>(T sender, EventArgs e) where T: class, IItem;	

	public class RelayCommand<T>(T item, ActionToExecute<T> execute) : ICommand<T> where T : class, IItem
	{
		public void Execute()
		{
			execute?.Invoke(item, EventArgs.Empty);
		}
	}
}
