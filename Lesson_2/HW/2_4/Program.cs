// Написать программу, которая выводит случайное трехзначное 
//число и удаляет вторую цифру из него

int th_number;
th_number = new Random().Next(100, 1000);

int randomThreeDigitNumber(int number)
{
  System.Console.WriteLine(th_number);
  int thirdNumber = th_number % 10;
  int firstNumber = (th_number / 100) * 10;
  th_number = thirdNumber + firstNumber;
  return th_number;
  
}
randomThreeDigitNumber(th_number);
System.Console.WriteLine(th_number);
