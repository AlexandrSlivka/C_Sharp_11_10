//Найдите произведение пар чисел в одномерном массиве.
//Парой считается первый и псоледний элемент, второй и
//предпоследний и т.д. Результат записать в новом массиве.

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

int[] ProductArr(int[] arr)
{
  int len = arr.Length;
  int[] result = new int[len/2 + len % 2];

  for (int i = 0; i < len / 2; i++)
  {
    result[i] = arr[i] * arr[len - i - 1];
  }
  if (len % 2 != 0)
    result[result.Length - 1] = arr[len / 2];
  return result;

}



System.Console.Write("Введите количество элементов в массиве: ");
int numberElementsArray = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите начало диапазона массива: ");
int beginningRange = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите конец диапазона массива: ");
int endRange = int.Parse(Console.ReadLine()!);
int[] mass = SettingArray(beginningRange, endRange, numberElementsArray);

ArrayOutput(mass);

int[] endArr = ProductArr(mass);
ArrayOutput(endArr);




