// Присутствуе ли заданное число в массиве


using System.Runtime.InteropServices;

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

bool CheckingNumber(int[] arr, int number)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == number)
      return true;
  }
  return false;
}

System.Console.Write("Ведите количество элементов в массиве: ");
int numberElementsArray = int.Parse(Console.ReadLine()!);

System.Console.Write("Ведите начало диапазона массива: ");
int beginningRange = int.Parse(Console.ReadLine()!);

System.Console.Write("Ведите конец диапазона массива: ");
int endRange = int.Parse(Console.ReadLine()!);
int[] mass = SettingArray(beginningRange, endRange, numberElementsArray);

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

ArrayOutput(mass);
System.Console.WriteLine(CheckingNumber(mass, num)); 

