// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным

int value;
System.Console.WriteLine("Введите день недели");
value = int.Parse(Console.ReadLine()!);
void dayWeek(int number)
{
  if (number > 0 && number < 6)
  {
    System.Console.WriteLine("Это будний день");
  }
  else if (number > 5 && number < 8)
  {
    System.Console.WriteLine("Выходной день");
  }
  else
    System.Console.WriteLine("Это не день недели");

}
dayWeek(value);