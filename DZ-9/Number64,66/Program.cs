// Задача 64.
// Программа выводит все натуральные числа от M до N.
// Задача 66.
// Программа находит сумму натуральных элементов от M до N.
// Дополнительное условие - всё надо сделать через рекурсию.
using static System.Console;
string text1 = "Введите начальное натуральное число: ";
string text2 = "Натуральное число ВСЕГДА больше нуля";
int M = InputNaturalNumber(text1, text2);
text1 = "Введите конечное натуральное число: ";
int N = InputNaturalNumber(text1, text2);
WriteLine($"Натуральные числа от {M} до {N}: ");
Console.WriteLine(NumbersRec(M, N));
WriteLine();
// int sum = (M + N) * (N - M + 1) / 2;
WriteLine($"Сумма натуральных чисел от {M} до {N} = {SumRec(M, N)}");
WriteLine();

string NumbersRec(int M, int N)
// выводит числа от M до N, где M<=N - через рекурсию.
{
    if (M < N) return $"{M} " + NumbersRec(M + 1, N);
    else return $"{M}";
}

int SumRec(int M, int N)
// Сумма чисел от M до N - через рекурсию.
{
    if (N == M) return M;
    else return N + SumRec(M, N - 1);
}


int InputNaturalNumber(string text1, string text2)
// Ввод натурального числа.
{
    int num = -1;
    while (num < 1)
    {
        num = InputInt(text1);
        if (num < 1) { WriteLine(text2); }
    }
    return num;
}

int InputInt(string text)
// Ввод целого числа.
{
    bool isNumber = false; int x = 0;
    while (!isNumber)
    {
        Write(text);
        isNumber = int.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}