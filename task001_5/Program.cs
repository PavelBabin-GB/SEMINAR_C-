// Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9] 
// наидите сумму отрицательных и положительных элементов массива.

int[] arrey = GetArrey(12, -9, 9);

int pos = 0;
int neg = 0;

int[] GetArrey(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
Console.Write("[");
foreach (int i in arrey)
{
    Console.Write(i + ",");
    pos += i > 0 ? i : 0;
    neg += i < 0 ? i : 0;
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"NEG = {neg} POS = {pos}");


