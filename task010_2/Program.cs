// Программа которая принимает на входе два числа и проверяет является ли одно число квадратом другого
Console.WriteLine("Введите первое число: ");
int nomberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int nomberB = int.Parse(Console.ReadLine());

//Можно так
//if ((nomberA*nomberA == nomberB) | (nomberB*nomberB == nomberA))
if (nomberA*nomberA == nomberB)
{
    Console.WriteLine("Является квадратом первого числа");
}
else if(nomberB*nomberB == nomberA)
    {
        Console.WriteLine("Является квадратом второго числа");
    }
else
{
    Console.WriteLine("Нет");
}
