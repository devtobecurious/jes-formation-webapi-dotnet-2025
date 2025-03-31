using System.Collections;

namespace DTBC.Ludotek.Pipelines
{
	public class Pipeline<Titem> : IOrchestrator<ICommand<Titem>> where Titem : class, IItem
	{
		private readonly List<ICommand<Titem>> _items = [];

		public ICommand<Titem> this[int index] { get => this._items[index]; set => this._items[index] = value; }

		public int Count => this._items.Count;

		public bool IsReadOnly => false;

		public void Add(ICommand<Titem> item)
		{
			this._items.Add(item);
		}

		public void Clear()
		{
			this._items.Clear();
		}

		public bool Contains(ICommand<Titem> item) => this._items.Contains(item);

		public void CopyTo(ICommand<Titem>[] array, int arrayIndex)
		{
			this._items.CopyTo(array, arrayIndex);
		}

		public Task Execute()
		{
			// on attend en async chaque fin de tache :
			// this._items.ForEach(async item => await item.Execute());
			//this._items.ForEach(item => item.Execute());
			var tasks = this._items.Select(item => item.Execute());

			return Task.WhenAll(tasks);
		}

		public IEnumerator<ICommand<Titem>> GetEnumerator() => this._items.GetEnumerator();

		public int IndexOf(ICommand<Titem> item) => this._items.IndexOf(item);

		public void Insert(int index, ICommand<Titem> item)
		{
			this._items.Insert(index, item);
		}

		public bool Remove(ICommand<Titem> item) => this._items.Remove(item);

		public void RemoveAt(int index)
		{
			this._items.RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
