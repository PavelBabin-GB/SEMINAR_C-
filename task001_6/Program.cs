// Программа которая переварачивает одномерный массив последний элемент будет на первом месте, а первый на последнем и тд.


int[] arrey = GetArrey(10, 0, 10);

int[] GetArrey(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}    
void reverseArrey(int[] localArrey)
{
    for (int i = 0; i < localArrey.Length / 2; i++)
    {
        int k = localArrey[i];
        localArrey[i] = localArrey[localArrey.Length - i - 1];
        localArrey[localArrey.Length - i - 1] = k;
    }
}
Console.WriteLine(String.Join(" ", arrey));
reverseArrey(arrey);
Console.WriteLine(String.Join(" ", arrey));

