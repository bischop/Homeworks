using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01_04
{
	// Создайте коллекцию, в которую можно записывать два значения одного слова, по типу русско-англо-украинский словарь.
	// И в ней можно для украинского слова найти либо только русское значение, либо только английское и вывести его на экран.

	class Program
	{
		static void Main()
		{
			OutputEncoding = Encoding.Unicode;

			WordsCollection collection = new();
			collection[0] = new WordItem("пес", "dog", "собака");
			collection[1] = new WordItem("зошит", "copybook", "тетрадь");
			collection[2] = new WordItem("вікно", "window", "окно");
			collection[3] = new WordItem("стіл", "table", "стол");

			WriteLine($"пес (ukr) - {collection["пес"].EngWord} (eng)");

			WriteLine($"вікно (ukr) - {collection["вікно"].RusWord} (rus)");

			WriteLine(new string('-', 19));

			foreach (WordItem wi in collection)
			{
				WriteLine($"{wi.UkrWord} - {wi.EngWord} - {wi.RusWord}");
			}

			ReadKey();


			/*List<WordItem> collection2 = new() {
				new WordItem("пес", "dog", "собака"),
				new WordItem("зошит", "copybook", "тетрадь"),
				new WordItem("вікно", "window", "окно"),
				new WordItem("стіл", "table", "стол")
			};

			Console.WriteLine($"пес (ukr) - {collection2.Where(x => x.UkrWord == "пес").FirstOrDefault().EngWord} (eng)");
			Console.WriteLine($"вікно (ukr) - {collection2.Where(x => x.UkrWord == "вікно").FirstOrDefault().EngWord} (eng)");

			Console.ReadKey();*/
		}
	}
}
