
void CubeNumbers(int number)
{
  double count = 1;
  double value;
  while (count <= number)
  {
    value = Math.Pow(count, 3);
    System.Console.Write($"{value} ");
    count++;

  }


}
System.Console.WriteLine("Введите число: ");
int result = int.Parse(Console.ReadLine()!);
CubeNumbers(result);