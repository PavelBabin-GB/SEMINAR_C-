// Программа которая случайное число из отрезка [10, 99]
// и показывает наибольшую цыфру числа

int num = new Random().Next(10, 100);
int num2 = num % 10;
int num1 = num / 10;
int max = num1;

Console.WriteLine($"num1 = {num1}, num2 = {num2}");

if (num2 > max)
{
  max = num2;
}

Console.WriteLine(max);

