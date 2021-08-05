using System.Collections;

namespace Task_01_02
{
	public class MonthsCollection : IEnumerable
	{
		readonly MonthItem[] collection = new MonthItem[12];

		int index = -1;
		int ordinal_filter = - 1;
		int days_filter = -1;

		public MonthItem this[int index]
		{
			get { return collection[index]; }
			set { collection[index] = value; }
		}

		public void SetOrdinalFilter(int new_value) => ordinal_filter = new_value;

		public void SetDaysFilter(int new_value) => days_filter = new_value;

		public IEnumerator GetEnumerator()
		{
			while (true)
			{
				if (index < collection.Length - 1)
				{
					index++;

					if ((ordinal_filter == -1 || collection[index].OrdinalNumber.Equals(ordinal_filter)) &&
						(days_filter    == -1 || collection[index].QuantityOfDays.Equals(days_filter)))
						yield return collection[index];
				}
				else
				{
					Reset();
					yield break;
				}
			}
		}

		public bool MoveNext()
		{
			if (index < collection.Length - 1)
			{
				index++;
				return true;
			}

			return false;
		}

		public void Reset()
		{
			index = -1;
			ordinal_filter = -1;
			days_filter = -1;
		}
	}
}
