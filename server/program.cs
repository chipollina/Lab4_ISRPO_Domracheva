Console.WriteLine("Hello, World!");
Console.WriteLine("ФИО:Домрачева Полина");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine("Дата и время: " + DateTime.Now);
Console.WriteLine("Меню:");
Console.WriteLine("1 — Показать ФИО");
 Console.WriteLine("2 — Показать группу");
Console.WriteLine("3 — Показать дату");
Console.WriteLine("4 — Выход");
Console.Write("Введите номер пункта: ");
string choice = Console.ReadLine();
if (choice == "1")
{Console.WriteLine($"ФИО: Иванов Иван Иванович");}
else if (choice == "2")
{Console.WriteLine($"Группа: ИСП-244");}
else if (choice == "3")
{Console.WriteLine($"Текущая дата и время: {DateTime.Now}");}
else if (choice == "4")
{Console.WriteLine("Выход из программы...");}
else
{Console.WriteLine("Такого пункта в меню нет.");}

