// Программа которая принимает на входе координаты точки (Х и У), причем Х ≠ 0 и У ≠ 0 и выдаут номер
// четверти плоскости в которой она находится
Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());
string getPlane(int xLocal, int yLocal)
{
    if(xLocal > 0 && yLocal > 0) return ("1");
    if(xLocal > 0 && yLocal < 0) return ("2");
    if(xLocal < 0 && yLocal < 0) return ("3");
    if(xLocal < 0 && yLocal > 0) return ("4");
    return ("err");
}
Console.WriteLine(getPlane(x, y));