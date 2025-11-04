

void Quarters(int x, int y)
{
  if (x == 0 || y == 0)
    System.Console.WriteLine("x=o, y =o");
  else if (x > 0 && y > 0)
    System.Console.WriteLine("I");
  else if (x < 0 && y > 0)
    System.Console.WriteLine("II");
  else if (x < 0 && y < 0)
    System.Console.WriteLine("III");
  else if (x > 0 && y < 0)
    System.Console.WriteLine("IV");

}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);