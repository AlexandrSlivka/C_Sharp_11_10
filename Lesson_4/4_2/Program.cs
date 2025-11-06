// Написать программу, которая принимает число N и выдает
// произведение числе от 1 до N

int ProductNumbers(int number)
{
  int count = 1;
  for (int i = 1; i <= number; i++)
  {
    count *= i;
  }
  return count;
}
System.Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine()!);
int result = ProductNumbers(value);
System.Console.WriteLine(result);