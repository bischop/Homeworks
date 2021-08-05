using System.Collections.Generic;
using static System.Console;

namespace Task_02_03
{
	// Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.

	class Program
	{
		static void Main()
		{
			var collection1 = new Dictionary<long, float>
			{
				{ 28716371467146, 5432.55f },
				{ 67146287163714,  432.55f },
				{ 94787485748847, 1923.71f }
			};

			var collection2 = new SortedDictionary<long, float>
			{
				[28716371467146] = 1,
				[67146287163714] = 2,
				[94787485748847] = 3
			};

			foreach (KeyValuePair<long, float> i in collection2) WriteLine(i);

			var collection3 = new List<BankEntry>
			{
				new BankEntry(28716371467146, 5432.55f),
                new BankEntry(67146287163714,  432.55f),
                new BankEntry(94787485748847, 1923.71f)
            };

			var collection4 = new LinkedList<BankEntry>();
			collection4.AddFirst(new BankEntry(94787485748847, 1923.71f));
			collection4.AddLast(new BankEntry(94787485748847, 1923.71f));


			ReadKey();
		}
	}

    public class BankEntry
    {
        public long CardNumber;
        public float CardBalans;

        public BankEntry(long CardNumber, float CardBalans)
        {
            this.CardNumber = CardNumber;
            this.CardBalans = CardBalans;
        }
    }
}
