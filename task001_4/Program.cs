// Программа которая принимает на входе число А и выдает суму от 1 до А
int getSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number;
        number = number - 1;
    }
    return sum;
} 
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(getSumNums(num));