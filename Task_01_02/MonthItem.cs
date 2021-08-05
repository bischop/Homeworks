namespace Task_01_02
{
	public class MonthItem
	{
		public string MonthName { get; set; }

		public int OrdinalNumber { get; set; }

		public int QuantityOfDays { get; set; }

		public MonthItem(string MonthName, int OrdinalNumber, int QuantityOfDays)
		{
			this.MonthName = MonthName;

			this.OrdinalNumber = OrdinalNumber;

			this.QuantityOfDays = QuantityOfDays;
		}
	}
}
