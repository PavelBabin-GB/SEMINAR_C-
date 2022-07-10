// Напишите программу где на входе принимает одно число n, а на выходе похазывает все целые числа 
//в промежутке от -n до n
Console.WriteLine("Ведите число n: ");
int number = int.Parse(Console.ReadLine());

for (int i = -number; i <= number; i++ )
{
    Console.WriteLine(i);
}
