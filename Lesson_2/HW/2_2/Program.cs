// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.




System.Console.WriteLine("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!);

void outputThirdDigit(int digit)
{
  if (digit < 100)
  {
    System.Console.WriteLine("В числе нет 3-ей цифры");
    return;
  }
  else if (digit > 99 && digit < 1000)
  {
    digit %= 10;
    System.Console.WriteLine(digit);
    return;
  }
  else if (digit > 999)
  {
    while (digit > 1000)
    {
      digit /= 10;
    }
    digit %= 10;
    System.Console.WriteLine(digit);
  }

  //return digit;


}
outputThirdDigit(number);



