// Задайте двумерный массив, найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты

int[,] GetArrey(int n, int m, int min, int max)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = CheckSqr(new Random().Next(min, max), i, j);
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
int CheckSqr(int numbers, int i, int j)
{
    if  (i%2 == 0 & j%2 == 0)
    {
        return numbers * numbers;
    }
    return numbers;
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrey = GetArrey(rows, columns, 0, 10);
PrintArrey(arrey);
