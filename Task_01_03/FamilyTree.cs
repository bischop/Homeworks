using System;
using System.Collections;

namespace Task_01_03
{
	public class FamilyTree : ICollection
	{
		private readonly Person[] Family = new Person[4];

		private int count = 0;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public void Clear() => count = 0;

		public int Count { get { return count; } }

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		public void PrintAllMembers()
		{
			for (int i = 0; i < count; i++)
			{
				Console.WriteLine($"{Family[i].Name} - {Family[i].BirthYear}");

				Family[i].FamilyMembers.PrintAllMembers();
			}
		}

		public void SearchMembersByYear(int year_for_search)
		{
			for (int i = 0; i < count; i++)
			{
				if (Family[i].BirthYear == year_for_search)
					Console.WriteLine($"{Family[i].Name} - {Family[i].BirthYear}");

				Family[i].FamilyMembers.SearchMembersByYear(year_for_search);
			}
		}

		public int Add(Person value)
		{
			if (count < Family.Length)
			{
				Family[count++] = value;

				return count - 1;
			}

			return -1;
		}

		public bool Contains(Person value)
		{
			for (int i = 0; i < count; i++)
			{
				if (Family[i] == value)
					return true;
			}

			return false;
		}

		public int IndexOf(Person value)
		{
			for (int i = 0; i < count; i++)
				if (Family[i] == value)
					return i;

			return -1;
		}

		public void Insert(int index, Person value)
		{
			if ((count + 1 <= Family.Length) && (index < count) && (index >= 0))
			{
				count++;

				for (int i = count - 1; i > index; i--)
				{
					Family[i] = Family[i - 1];
				}
				Family[index] = value;
			}
		}

		public void Remove(Person value)
		{
			RemoveAt(IndexOf(value));
		}

		public void RemoveAt(int index)
		{
			if ((index >= 0) && (index < count))
			{
				for (int i = index; i < count - 1; i++)
					Family[i] = Family[i + 1];

				count--;
			}
		}

		public void CopyTo(Array array, int index)
		{
			int j = index;
			for (int i = 0; i < Count; i++)
			{
				array.SetValue(Family[i], j);
				j++;
			}
		}

		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < count; i++)
			{
				yield return Family[i];
			}
		}

		public Person this[int index]
		{
			get
			{
				return Family[index];
			}
			set
			{
				Family[index] = value;
			}
		}
	}
}
