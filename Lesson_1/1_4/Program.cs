// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число1");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число2");
int number2 = int.Parse(Console.ReadLine()!);

if (number > number2)
{
  System.Console.WriteLine(number);
}
else System.Console.WriteLine(number2);