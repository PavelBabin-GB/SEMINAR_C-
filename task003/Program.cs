// Напишите программу которая будет выводит название дня недели по заданному номеру.
Console.WriteLine("Введите номе от 1 до 7");
int nomber = int.Parse(Console.ReadLine());

if (nomber > 7) Console.WriteLine("ЭТО ЧИСЛО НЕ ПРИНАДЛЕЖИТ НИ ОДНОМУ ДНЮ НЕДЕЛИ");
else
{
    if (nomber == 1) Console.WriteLine("Понедельник");
    if (nomber == 2) Console.WriteLine("Вторник");
    if (nomber == 3) Console.WriteLine("Среда");
    if (nomber == 4) Console.WriteLine("Четверг");
    if (nomber == 5) Console.WriteLine("Пятница");
    if (nomber == 6) Console.WriteLine("Суббота");
    if (nomber == 7) Console.WriteLine("Воскресенье");
}
