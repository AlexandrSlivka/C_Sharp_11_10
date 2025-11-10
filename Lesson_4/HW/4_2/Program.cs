// : Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

using System.Runtime.InteropServices;



int SumNumber(int value)
{
  int count = 0;
  int sum = 0;

  while (value > 0)
  {
    count = value % 10;

    value /= 10;
    sum += count;

  }
  
  return sum;
}

int val = int.Parse(Console.ReadLine()!);
int result = SumNumber(val);
System.Console.WriteLine(result);