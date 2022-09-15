// Задача 68.
// Программа вычисляет функцию Аккермана с помощью рекурсии.
using static System.Console;
string text1 = "Введите первый аргумент функции Аккермана: ";
string text2 = "Аргументы не должны быть меньше нуля";
int M = InputNaturalNumberPlusNull(text1, text2);
text1 = "Введите второй аргумент функции Аккермана: ";
int N = InputNaturalNumberPlusNull(text1, text2);
int[] A = new int[2];
A[0] = M;
A[1] = N;
Akkerman(A);
WriteLine($"Akkerman({M},{N}) = {A[1]}");

void Akkerman(int[] A)
// Функция Аккермана
{
    if (A[0] == 0) { A[1]++; }
    else if (A[1] == 0 && A[0] > 0)
    {
        A[0]--;
        A[1] = 1;
        Akkerman(A);
    }
    else
    {
        int mm = A[0] - 1;
        A[1]--;
        Akkerman(A);
        A[0] = mm;
        Akkerman(A);
    }
}

int InputNaturalNumberPlusNull(string text1, string text2)
// Ввод натурального числа + 0.
{
    int num = -1;
    while (num < 0)
    {
        num = InputInt(text1);
        if (num < 0) { WriteLine(text2); }
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
