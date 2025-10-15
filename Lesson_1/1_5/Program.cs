Console.WriteLine("введите число1");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число2");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число3");
int number3 = int.Parse(Console.ReadLine()!);

if (number > number2 && number > number3)
{
  System.Console.WriteLine(number);
}
else if (number2 > number && number2 > number3)
{
  System.Console.WriteLine(number2);
} 
else if (number3 > number && number3 > number2)
{
  System.Console.WriteLine(number3);
} 
