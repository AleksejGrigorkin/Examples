//Задача 23
//Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
int x1 = ReadNumber("Введите ", "целое ", "число: ");
if (x1 != 0)
{
    int x2 = Math.Abs(x1);
    int[] arrey = new int[x2];
    arrey = GetTab(x2);
    Write($"Кубы от 1 до {x2}: ");
    Write(arrey[0]);
    for (int i = 1; i < x2; i++)
    {
        Write($", {arrey[i]}");
    }
}
else
{
    Write(x1);
}
WriteLine();

int ReadNumber(string a, string b, string c)
{
home:
    Write(a + b + c);
    bool isNumber = int.TryParse(ReadLine(), out int x);
    if (!isNumber)
    {
        WriteLine("Это не число");
        goto home;
    }
    return x;
}


int[] GetTab(int x2)
{
    int[] arrey = new int[x2];
    for (int i = 1; i < x2 + 1; i++)
    {
        arrey[i - 1] = i * i * i;
    }
    return arrey;
}