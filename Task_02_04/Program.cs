using System.Collections;
using System.Collections.Specialized;
using static System.Console;

namespace Task_02_04
{
	// Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений.

	class Program
	{
		static void Main()
		{
			var emailLookup = new OrderedDictionary(new InsensitiveComparer())
			{
				{ "sbishop@contoso.com", "Bishop, Scott" },
				{ "Sbishop@contoso.COM", "Bishop, Scott" },
				{ "chess@contoso.com", "Hell, Christian" },
				{ "djump@contoso.com", "Jump, Dan" }
			};

			foreach (DictionaryEntry entry in emailLookup)
			{
				WriteLine(entry.Value);
			}

			ReadKey();
		}
	}

	public class InsensitiveComparer : IEqualityComparer
	{
		readonly CaseInsensitiveComparer comparer = new();

		public int GetHashCode(object obj)
		{
			return obj.ToString().ToLowerInvariant().GetHashCode();
		}

		public new bool Equals(object x, object y)
		{
			return comparer.Compare(x, y) == 0;
		}
	}
}
