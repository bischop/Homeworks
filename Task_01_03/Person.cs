namespace Task_01_03
{
	public class Person
	{
		public string Name { get; set; }

		public int BirthYear { get; set; }

		public FamilyTree FamilyMembers { get; set; }

		public Person(string Name, int BirthYear)
		{
			this.Name = Name;

			this.BirthYear = BirthYear;

			FamilyMembers = new FamilyTree();
		}
	}
}
