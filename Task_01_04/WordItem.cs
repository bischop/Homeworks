namespace Task_01_04
{
	public class WordItem
	{
		public string UkrWord { get; set; }

		public string EngWord { get; set; }

		public string RusWord { get; set; }

		public WordItem(string UkrWord, string EngWord, string RusWord)
		{
			this.UkrWord = UkrWord;

			this.EngWord = EngWord;

			this.RusWord = RusWord;
		}
	}
}
