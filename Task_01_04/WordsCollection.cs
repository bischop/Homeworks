using System;
using System.Collections;

namespace Task_01_04
{
	public class WordsCollection : ICollection
	{
		private readonly WordItem[] collection = new WordItem[4];

		public int Count => collection.Length;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		public WordItem this[int index]
		{
			get { return collection[index]; }
			set { collection[index] = value; }
		}

		public WordItem this[string key]
		{
			get
			{
				for (int i = 0; i < collection.Length; i++)
					if (collection[i].UkrWord.Equals(key))
						return collection[i];

				throw new IndexOutOfRangeException();
			}
		}

		public IEnumerator GetEnumerator()
		{
			return collection.GetEnumerator();
		}

		public void CopyTo(Array array, int index)
		{
			int j = index;
			for (int i = 0; i < Count; i++)
			{
				array.SetValue(collection[i], j++);
			}
		}
	}
}
