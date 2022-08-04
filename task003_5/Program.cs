// Задайте массив, напишите программу, которая  определяет, находится ли задонное число в массиве.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());

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
String Search(int x)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] == x) return "Да присуцтвует";
    }
    return "Не присуцтвует";
}
Console.WriteLine(Search(x));
