
void palindrome(int number)
{
  if ((number / 10000 == number % 10) &&
  (number / 1000 % 10 == number % 100 / 10))
    System.Console.WriteLine("Число палиндром");
  else
    System.Console.WriteLine("Число не палиндром");

}
int result = int.Parse(Console.ReadLine()!);
palindrome(result);
