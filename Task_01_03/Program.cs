using static System.Console;

namespace Task_01_03
{
	// Создайте коллекцию, которая бы по своей структуре напоминала «родовое дерево» (имя человека, год рождения),
	// причем в нее можно добавлять/удалять нового родственника, есть возможность увидеть всех наследников выбранного человека, отобрать родственников по году рождения.

	class Program
	{
		static void Main()
		{
			FamilyTree Tree = new FamilyTree();

			Tree.Add(new Person("Ivan", 1960));
			Tree.Add(new Person("Katya", 1962));
			Tree.Add(new Person("Stepan", 1962));

			Tree[0].FamilyMembers.Add(new Person("Olesya", 1986));
			Tree[0].FamilyMembers.Add(new Person("Nadja", 1990));
			Tree[1].FamilyMembers.Add(new Person("Petya", 1990));

			Tree[0].FamilyMembers[0].FamilyMembers.Add(new Person("Tanya", 2005));
			Tree[0].FamilyMembers[1].FamilyMembers.Add(new Person("Vitya", 2007));

			WriteLine(new string('-', 20));
			Tree.PrintAllMembers();

			WriteLine(new string('-', 20));
			Tree.SearchMembersByYear(2005);

			WriteLine(new string('-', 20));
			Tree.SearchMembersByYear(1990);

			Person p = Tree[0].FamilyMembers[0];
			Tree[0].FamilyMembers.Remove(p);

			WriteLine(new string('-', 20));
			Tree.PrintAllMembers();

			ReadLine();
		}
	}
}
