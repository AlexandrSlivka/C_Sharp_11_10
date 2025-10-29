int LargestNumber(int num)
{
  System.Console.WriteLine(num);
  int num1 = num / 10;
  int num2 = num % 10;
  if (num1 > num2)
    return num1;
  return num2;
}

int largest = new Random().Next(10, 100);//убирает 1 от 1000, будет до 999
int result = LargestNumber(largest);
//int largest = result(new Random().Next(10, 100));
System.Console.WriteLine(result);