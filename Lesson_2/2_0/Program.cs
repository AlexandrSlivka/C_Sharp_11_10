
// Напишите программу, которая принимает на вход трехзначное чило
// и на выход показывает последнюю цифру этого числа

//функции

int TakeNum(int num)
{
  System.Console.WriteLine(num);
  return num % 10;
}

int th_num = new Random().Next(100, 1000);//убирает 1 от 1000, будет до 999
int result = TakeNum(th_num);
System.Console.WriteLine(result);