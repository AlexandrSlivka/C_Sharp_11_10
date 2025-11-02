// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

using System.Net;

int number;
System.Console.WriteLine("Введите любое число: ");
number = int.Parse(Console.ReadLine()!);

int outputThirdDigit(int digit)
{
  if (number < 100)
  {
    System.Console.WriteLine("Вчисле нет 3-ей цифры");
  }
  else if (number > 99 && number < 1000)
  {
    number %= 10;
    System.Console.WriteLine(number);
  }
  else if (number > 999)
  {
    System.Console.WriteLine("Число больше трехзначного");
  }

return number;
  
  
}
outputThirdDigit(number);

