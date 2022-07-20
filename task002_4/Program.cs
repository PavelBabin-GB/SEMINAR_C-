// Программа которая принимает на вход число и выдает количество цыфр в числе
int getLength(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;        
    }
    return count;
}
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(getLength(n));