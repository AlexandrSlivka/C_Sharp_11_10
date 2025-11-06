// Напишите программу, которая принимает число и показывает
// сколько в нем цифр

int NumberDigits(int number)
{
  int count = 0;
  for (int i = 1; number > 0; i++)
  {
    number /= 10;
    count = i;
  }
  return count;
}
System.Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine()!);
int result = NumberDigits(value);
System.Console.WriteLine(result);

