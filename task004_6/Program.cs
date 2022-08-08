// Не используя рекурсию, выведите первые n чисел Фибаначи. Первые два числа Фибаначи 0 и 1

int[] GetArreyFib(int n)
{
    int[] numbers = new int[n];
    numbers[0] = 0;
    numbers[1] = 1;
    return numbers;
}
int[] AddNumbFib(int[] numbers)
{
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }
    return numbers;
}
Console.WriteLine("Enter numbers");
int n = int.Parse(Console.ReadLine());
int[] number = GetArreyFib(n);
number = AddNumbFib(number);
foreach (int item in number)
{
    Console.Write(item + " ");
} 
