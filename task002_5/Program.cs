// Напишите программу замены элементов массива: отрицательные замените на положительные и наоборот.

int[] arrey = GetArrey(12, -9, 9);

int[] GetArrey(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

    
    void Reverse ()
    {
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] *= -1;
            
        }
    }
    Reverse ();
    Console.WriteLine();
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", arrey), "]");