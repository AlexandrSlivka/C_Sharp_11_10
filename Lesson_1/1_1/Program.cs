
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число:");
int num2 = int.Parse(Console.ReadLine()!);

if (num == num2 * num2)
  {
    Console.WriteLine($"Число {num} являетя квадратом {num2}");
  }
  else
  {
    Console.WriteLine($"Число {num} не являетя квадратом {num2}");
  }