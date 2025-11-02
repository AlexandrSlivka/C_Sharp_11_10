// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным

int value;
System.Console.WriteLine("Введите день недели");
value = int.Parse(Console.ReadLine()!);
void dayWeek(int number)
{
  if (value > 0 && value < 6)
  {
    System.Console.WriteLine("Это будний день");
  }
  else if (value > 5 && value < 8)
  {
    System.Console.WriteLine("Выходной день");
  }
  else
    System.Console.WriteLine("Это не день недели");

}
dayWeek(value);