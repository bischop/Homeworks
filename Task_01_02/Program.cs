using static System.Console;

namespace Task_01_02
{
	class Program
	{
		// Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и количество дней в соответствующем месяце.
		// Реализуйте возможность выбора месяцев, как по порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не только один месяц.

		static void Main()
		{
			MonthsCollection collection = new();
			collection[0] = new MonthItem("January", 1, 31);
			collection[1] = new MonthItem("February", 2, 28);
			collection[2] = new MonthItem("March", 3, 31);
			collection[3] = new MonthItem("April", 4, 30);
			collection[4] = new MonthItem("May", 5, 31);
			collection[5] = new MonthItem("June", 6, 30);
			collection[6] = new MonthItem("July", 7, 31);
			collection[7] = new MonthItem("August", 8, 31);
			collection[8] = new MonthItem("September", 9, 30);
			collection[9] = new MonthItem("October", 10, 31);
			collection[10] = new MonthItem("November", 11, 30);
			collection[11] = new MonthItem("December", 12, 31);

			foreach (MonthItem m in collection)
			{
				WriteLine($"{m.OrdinalNumber:00} - {m.MonthName,9} - {m.QuantityOfDays}");
			}

			WriteLine(new string('-', 19));

			collection.SetOrdinalFilter(2);

			foreach (MonthItem m in collection)
			{
				WriteLine($"{m.OrdinalNumber:00} - {m.MonthName,9} - {m.QuantityOfDays}");
			}

			WriteLine(new string('-', 19));

			collection.SetDaysFilter(30);

			foreach (MonthItem m in collection)
			{
				WriteLine($"{m.OrdinalNumber:00} - {m.MonthName,9} - {m.QuantityOfDays}");
			}

			ReadLine();
		}
	}
}
