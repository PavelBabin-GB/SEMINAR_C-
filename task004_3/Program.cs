// Программа которая принимает на входе число n и выдает таблицу квадратов чисел от 1 до n
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
double Result(int iLocal)
{
    return Math.Pow(iLocal, 2);
}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Result(i));
}