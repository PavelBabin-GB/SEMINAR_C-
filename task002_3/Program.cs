// Программа которая по заданному номеру четверти показывает диапозон возможных коардинат точек в этой 
//плоскости Х и У
string gotRange(int q)
{
    if (q == 1) return "x > 0, y > 0";
    if (q == 2) return "x > 0, y < 0";
    if (q == 3) return "x < 0, y < 0";
    if (q == 4) return "x < 0, y > 0";
    return "";
}
int q;
do
{
    Console.WriteLine("Введите число: ");
    q = int.Parse(Console.ReadLine());
}
while (q < 1 || q > 4);
Console.WriteLine(gotRange(q));