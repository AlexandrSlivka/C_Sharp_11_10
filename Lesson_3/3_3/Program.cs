// Напишите программу, которая принимает на вход число N 
// и выдает таблицу квадратов числе от 1 до N

using System.ComponentModel;

void SquareNumbers(int number)
{
  double count = 1;
  double volue;
  while (count <= number)
  {

    volue = Math.Pow(count, 2);
    System.Console.Write($"{volue} ");
    count++;
    
    
  }
  
}
int num = int.Parse(Console.ReadLine()!);
SquareNumbers(num);
