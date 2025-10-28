Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine()!);
int number2 = 2;

 
while (number2 <= number)
{
  System.Console.Write($"{number2} ");
  number2 = number2 + 2;
  
}
