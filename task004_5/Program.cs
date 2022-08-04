// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значение 
// которых лежат в отрезке [10, 99]

int[] arrey = GetArrey(123, -100, 1000);

int[] GetArrey(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    //Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}
//foreach (var i in arrey)
//{
//    Console.Write ($" {i} ");
//}
Console.WriteLine();
int Count(int[] ar)
{
    int j = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] >= 10 & ar[i] <= 99) j = j + 1;
    }
    return j;
} 
Console.WriteLine($"В интервале [10, 99] поподает {Count(arrey)} элемента");