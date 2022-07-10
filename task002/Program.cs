// Напишите программу которая на вход принимае два числа и проверяет является ли первое число корнем второго.
Console.WriteLine("Введите первое число: ");
int nomberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int nomberB = int.Parse(Console.ReadLine());
if (nomberB == nomberA/nomberB)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Лож");
}
