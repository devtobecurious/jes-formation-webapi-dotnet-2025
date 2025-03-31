using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverTasks
{
	public class Breakfast
	{
		[Benchmark]
		public Task Make()
		{
			Console.WriteLine("Making breakfast...");
			//await MakeEggs();
			//await MakeToast();
			//await MakeCoffee();
			return Task.WhenAll(MakeEggs(), MakeToast(), MakeCoffee());
		}

		public async Task MakeEggs()
		{
			await Task.Delay(200);
			Console.WriteLine("Making eggs...");
		}

		public async Task MakeToast()
		{
			await Task.Delay(300);
			Console.WriteLine("Making toast...");
		}

		public async Task MakeCoffee()
		{
			await Task.Delay(500);
			Console.WriteLine("Making coffee...");
		}
	}
}
