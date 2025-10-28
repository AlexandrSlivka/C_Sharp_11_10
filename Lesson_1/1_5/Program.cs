Console.WriteLine("введите число1");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число2");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число3");
int number3 = int.Parse(Console.ReadLine()!);

if (number < number2)
{
  number = number2;
}
if (number < number3)
{
  number = number3;
} 
Console.WriteLine(number);
 
