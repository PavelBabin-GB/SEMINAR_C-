// Программа которая принимает на входе три числа и проверяет может ли быть треугольник со сторонами такой длинны

void CheckTriangle(int a, int b, int c)
{
    if ((a + b) > c && (a + c) > b && (c + b) > a)
    {
        Console.WriteLine("Есть треугольник с такими сторонами");
    }
    else
    Console.WriteLine("Нет треугольник с такими сторонами");
}    
Console.WriteLine("Введите три длинны сторон треугольника через пробел: ");

string[] arrey = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
int a = int.Parse(arrey[0]);
int b = int.Parse(arrey[1]);
int c = int.Parse(arrey[2]);
CheckTriangle(a, b, c);
