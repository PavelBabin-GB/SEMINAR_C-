// функция для перевода из десятичной в любую

Console.WriteLine("Введите число для перевода: ");
int decNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите функцию: ");
int otherSustem = int.Parse(Console.ReadLine());

string DecToNum(int decNumber, int otherSustem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while(decNumber > 0)
    {
        int oct = decNumber / otherSustem;
        res = nums[decNumber - otherSustem * oct] + res;
        decNumber /= otherSustem;
    }
    return res;
}
Console.WriteLine(DecToNum(decNumber, otherSustem));