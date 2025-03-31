using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTBC.Ludotek.Pipelines
{
	public interface IExecutor<T> where T: class
	{
		/// <summary>
		/// 
		/// </summary>
		Task Execute();
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	//public interface IOrchestrator<T, U> : IExecutor<T>, IList<T> where T : class, ICommand<U>
	//															  where U : class, IItem
	public interface IOrchestrator<T> : IExecutor<T>, IList<T> where T : class
	{
	}
}
