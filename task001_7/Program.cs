// Задайте двухмерный массив размером MxN, заполненый случайными целыми числами

int[,] GetArrey(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = new Random().Next(min, max +1);
        }
    }
    return result;
}
void PrintArrey(int[,] inArrey)
{
    for (int i = 0; i < inArrey.GetLength(0); i++)
    {
        for (int j = 0; j < inArrey.GetLength(1); j++)
        {
           Console.Write($"{inArrey[i, j]} ");   
        }
        Console.WriteLine();
    }
    
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrey = GetArrey(rows, columns, 0, 10);
PrintArrey(arrey);
