

void Cordinate(int a)
{
  if (a == 1)
    System.Console.WriteLine("x > 0 and y > 0");
  else if (a == 2)
    System.Console.WriteLine("x < 0 and y > 0");
  else if (a == 3)
    System.Console.WriteLine("x < 0 and y < 0");
  else if (a == 4)
    System.Console.WriteLine("x > 0 and y < 0");
else System.Console.WriteLine("Нет такой четверти");
}
int quarter = int.Parse(Console.ReadLine()!);
Cordinate(quarter);

