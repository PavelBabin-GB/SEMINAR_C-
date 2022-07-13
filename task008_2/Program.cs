// Программа которая принимает на входе два числа и выводит, является ли второе число кратным первому
Console.WriteLine("Введите первое число: ");
int nomberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int nomberB = int.Parse(Console.ReadLine());


if (nomberA % nomberB == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Не кратное, остаток = "+ nomberA%nomberB);
}