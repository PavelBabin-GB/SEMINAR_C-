// Напишите программу которая принимает на вход трехзначное число и на выход показывает последнюю цыфру этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine(number % 10 );
}    
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}