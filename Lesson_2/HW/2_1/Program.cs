//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру 
//этого числа.

int th_number;
System.Console.WriteLine("Введите трехзначное число: ");
th_number = int.Parse(Console.ReadLine()!);

int threeDigitNumber(int number)
{
  
  th_number /= 10;
  th_number %= 10;
  return th_number;
}
threeDigitNumber(th_number);
System.Console.WriteLine(th_number);