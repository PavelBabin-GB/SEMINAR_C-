// Напишите программу замены элементов массива: отрицательные замените на положительные и наоборот.

int[] GetArrey(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
int[] arrey = GetArrey(12, -9, 9);
    for (int i = 0; i < arrey.Length; i++)
        {
            Console.Write(arrey[i] + " ");
        }
    Console.WriteLine();
    void Print (int[] ar)
    {
        for (int i = 0; i < ar.Length; i++)
        {
            ar[i] *= -1;
            Console.Write(ar[i] + " ");
        }
    }
    Print (arrey);