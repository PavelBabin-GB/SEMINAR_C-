// Программа которая принимает на входе число и проверяет кратно ли оно одновременно 7 и 23
Console.WriteLine("Введите число: ");
int nomber = int.Parse(Console.ReadLine());

if (nomber % 7 == 0 & nomber % 23 == 0)
{
    Console.WriteLine("Кратное числам 7 и 23");
}
else
{
    Console.WriteLine("Не кратное числам 7 и 23");
}
