// Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.


int Exponentiation(int number, int number2)
{
  int multiplication = 1;
  for (int i = 1; i <= number2; i++)
  {

    multiplication *= number;

  }
  return multiplication;
}
System.Console.Write("Введите число А: ");
int valueFirst = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число В: ");
int valueSecond = int.Parse(Console.ReadLine()!);
int result = Exponentiation(valueFirst, valueSecond);

System.Console.WriteLine($"Число {valueFirst} в степени {valueSecond} = {result}");