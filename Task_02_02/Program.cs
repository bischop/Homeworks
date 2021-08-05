using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Task_02_02
{
	// Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции.
	// Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей.

	class Program
	{
		static void Main()
		{
			var collection = new List<Tuple<string, string>>
			{
				new Tuple<string, string>( "Tanya", "Computers" ),
				new Tuple<string, string>( "Stepan", "Fruits" ),
				new Tuple<string, string>( "Ivan", "Computers" ),
				new Tuple<string, string>( "Tanya", "Fruits" ),
				new Tuple<string, string>( "Vasyl", "Books" )
			};

			var commodity = collection.OrderBy(x => x.Item2).Select(x => x.Item2).Distinct().ToList();
			foreach (var i in commodity)
				WriteLine(i);

			WriteLine(new string('-', 20));

			var fruits = collection.Where(x => x.Item2 == "Fruits").OrderByDescending(x => x.Item1).Select(x => x.Item1).Distinct().ToList();
			foreach (var i in fruits)
				WriteLine(i);

			ReadKey();
		}
	}
}
