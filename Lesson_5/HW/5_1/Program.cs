//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

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

int EvenNumber(int [] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {

    if (arr[i] % 2 == 0)
    {
      count++;
    }
  }

  return count;
}


System.Console.Write("Введите количество элементов в массиве: ");
int numberElementsArray = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите начало диапазона массива: ");
int beginningRange = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите конец диапазона массива: ");
int endRange = int.Parse(Console.ReadLine()!);
int[] mass = SettingArray(beginningRange, endRange, numberElementsArray);

ArrayOutput(mass);

int result = EvenNumber(mass);
System.Console.WriteLine("Количество четных чисел: ");
System.Console.WriteLine(result);




