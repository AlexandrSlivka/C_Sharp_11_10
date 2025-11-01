
// кратность числа. кратно ли первое число второму 
int number, number1;
System.Console.Write("Введите число 1: ");
number = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите число 2: ");
number1 = int.Parse(Console.ReadLine()!);

void multiplicityNumber(int num, int num1)
{
  if (number % number1 == 0)
    System.Console.WriteLine($"Число {number} кратно числу {number1}");
  else
  {
    System.Console.WriteLine(number % number1);
  }
}
multiplicityNumber(number, number1);
