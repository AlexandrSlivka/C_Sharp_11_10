// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine()!);
int number2 = -number;
while (number >= number2)
{
  System.Console.WriteLine(number2);
  number2++;
}


  
