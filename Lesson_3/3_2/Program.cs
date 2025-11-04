// Написать программу, которая на вход принимает координаты
// двух точек и находит расстояние между ними в 2d простаранстве

double Distance(int x1, int y1, int x2, int y2)
{
  return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
int x_1 = int.Parse(Console.ReadLine()!);
int y_1 = int.Parse(Console.ReadLine()!);
int x_2 = int.Parse(Console.ReadLine()!);
int y_2 = int.Parse(Console.ReadLine()!);

double result = Distance(x_1, y_1, x_2, y_2);
System.Console.WriteLine(result);


