// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите день недели");
int dayWeek = int.Parse(Console.ReadLine()!);

if (dayWeek == 1)
{
  System.Console.WriteLine("понедельник");
}
else if (dayWeek == 2)
{
  System.Console.WriteLine("вторник");
}
else if (dayWeek == 3)
{
  System.Console.WriteLine("среда");
}
else if (dayWeek == 4)
{
  System.Console.WriteLine("Четверг");
}
else if (dayWeek == 5)
{
  System.Console.WriteLine("пятница");
}
else if (dayWeek == 6)
{
  System.Console.WriteLine("суббота");
}
else if (dayWeek == 7)
{
  System.Console.WriteLine("воскресение");
}
else
{
  System.Console.WriteLine("это не день недели");
}