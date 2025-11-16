// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

using System.ComponentModel.DataAnnotations;

double[] SettingArray(int firstNumber, int secondNumber, int size)
{
  double[] myArray = new double[size];
  Random n_new = new Random();

  for (int i = 0; i < size; i++)
      myArray[i] = Math.Round(n_new.NextDouble() * (firstNumber - secondNumber) + secondNumber,2);
  return myArray;
}

void ArrayOutput(double[] arr)
{
  int size = arr.Length;

  System.Console.WriteLine("Вывод массива: ");
  for (int i = 0; i < size; i++)
  {
    System.Console.Write($" {arr[i]} ");
  }
  System.Console.WriteLine();
}

void DiffMaxMin(double[] arr)
{
  double n_max = arr[0];
  double n_min = arr[0];

  for (int i = 1; i < arr.Length; i++)
  {
    if (n_max < arr[i])
      n_max = arr[i];

    else if (n_min > arr[i])
      n_min = arr[i];
  }
  System.Console.WriteLine($"Max: {n_max}, min: {n_min}. ");
  System.Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min,2)}");
}



System.Console.Write("Введите количество элементов в массиве: ");
int numberElementsArray = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите начало диапазона массива: ");
int beginningRange = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите конец диапазона массива: ");
int endRange = int.Parse(Console.ReadLine()!);
double[] mass = SettingArray(beginningRange, endRange, numberElementsArray);

ArrayOutput(mass);
DiffMaxMin(mass);

