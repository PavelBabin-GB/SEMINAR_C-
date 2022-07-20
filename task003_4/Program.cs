// Программа которая выводит массив из 8 элементов заполненный нулями и единицами в случайом порядке
int[] GetNewArrey(int lengthArr)
{
    int[] arrey = new int[lengthArr];
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(0, 2);
    }
    return arrey;
}
foreach (int item in GetNewArrey(8))
{
    Console.Write(item + " ");
}