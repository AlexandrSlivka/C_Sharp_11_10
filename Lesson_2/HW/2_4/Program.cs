// Написать программу, которая выводит случайное трехзначное 
//число и удаляет вторую цифру из него

int th_number;
th_number = new Random().Next(100, 1000);

int randomThreeDigitNumber(int number)
{
  System.Console.WriteLine(number);
  int thirdNumber = number % 10;
  int firstNumber = (number / 100) * 10;
  number = thirdNumber + firstNumber;
  return number;

}
int result = randomThreeDigitNumber(th_number);

System.Console.WriteLine(result);
