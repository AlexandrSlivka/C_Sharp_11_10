// Написсать программу, котораявыводит массив из заданного количества
// эллементов и заполняет его случайными цифрами от 0 до 1

void BinarArray(int number)
{
  int[] array = new int[number];

  for (int i = 0; i < number; i++)
  {
    array[i] = new Random().Next(2);
    System.Console.Write($"{array[i]} ");
  }
  
}
int val = int.Parse(Console.ReadLine()!);
BinarArray(val);
