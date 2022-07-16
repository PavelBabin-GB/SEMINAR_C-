// Программа котороя принимает на вход коордионаты двух точек и находит расстояние между ними в 2D пространстве 
Console.WriteLine("Введите Xa");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Xb");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Yb");
int yb = int.Parse(Console.ReadLine());

double Distance (int xaLocal, int yaLocal, int xbLocal, int ybLocal)
{
    double dis = Math.Sqrt(Math.Pow(xbLocal - xaLocal, 2) + Math.Pow(ybLocal - yaLocal, 2));
    return dis;
}
Console.WriteLine(Distance(xa, ya, xb, yb));