// программа принимающая число и проверяющая кратно ли оно
//одновременно 7 и 23

int number;
System.Console.Write("Введите число 1: ");
number = int.Parse(Console.ReadLine()!);

void multiplicityNumber(int num)
{
  if (number % 7 == 0 && number % 23 == 0)
    System.Console.WriteLine($"Число {number} кртно 7 и 23");
  else
    System.Console.WriteLine("Число не крано двум числам");
}
multiplicityNumber(number);