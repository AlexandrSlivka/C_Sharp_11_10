//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру 
//этого числа.


System.Console.WriteLine("Введите трехзначное число: ");
int th_number = int.Parse(Console.ReadLine()!);

string threeDigitNumber(int number)
{
  if ((-1000 < number && number < -99) || (number < 1000 && number > 99))
    return $"{number / 10 % 10}";
  return "The number is not three-digit!";
  // th_number /= 10;
  // th_number %= 10;
  // return th_number;
}

string result = threeDigitNumber(th_number);
System.Console.WriteLine(result);