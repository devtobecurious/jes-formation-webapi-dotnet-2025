using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverEvents
{
	public enum Severity
	{
		None = 0,
		Not	= 1,
		Warning = 2,
		Urgent = 3
	}

	internal delegate void OnFire(Address address, Severity severity);

	internal class CallingCenter : IDisposable
	{
		private event OnFire FireOccuring;

		public void Subscribe(OnFire subscriber)
		{
			this.FireOccuring += subscriber;
		}

		public void Call(Address address, Severity severity)
		{
			this.FireOccuring?.Invoke(address, severity);
		}

		public void Dispose()
		{
			// Dispose ici ;)
			// this.FireOccuring.GetInvocationList
		}
	}
}
