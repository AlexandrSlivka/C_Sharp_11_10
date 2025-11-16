// Зайдайте массив из 123 случайных чисел
// Найдите кол-во эл. которые лежат в отрезке от 10 до 99
// включительно


using System.Data;

int[] SettingArray(int firstNumber, int secondNumber, int size)
{
  int[] myArray = new int[size];

  for (int i = 0; i < size; i++)
      myArray[i] = new Random().Next(firstNumber, secondNumber + 1);
  return myArray;
}

void ArrayOutput(int[] arr)
{
  int size = arr.Length;

  System.Console.WriteLine("Вывод массива: ");
  for (int i = 0; i < size; i++)
  {
    System.Console.Write($" {arr[i]} ");
  }
  System.Console.WriteLine();
}

int NumberElementsFromSegment(int[] arr)
{
  int numberElements = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= 10 && arr[i] <= 99)
    {
      numberElements += 1;
    }    
  }
  return numberElements;  
}

System.Console.Write("Введите количество элементов в массиве: ");
int numberElementsArray = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите начало диапазона массива: ");
int beginningRange = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите конец диапазона массива: ");
int endRange = int.Parse(Console.ReadLine()!);
int[] mass = SettingArray(beginningRange, endRange, numberElementsArray);



ArrayOutput(mass);
System.Console.WriteLine(NumberElementsFromSegment(mass));


