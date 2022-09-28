// Задача 68.
// Программа вычисляет функцию Аккермана с помощью рекурсии.
using static System.Console;
string text1 = "Введите первый аргумент функции Аккермана: ";
string text2 = "Аргументы не должны быть меньше нуля";
int M = InputNaturalNumberPlusNull(text1, text2);
text1 = "Введите второй аргумент функции Аккермана: ";
int N = InputNaturalNumberPlusNull(text1, text2);
WriteLine($"Akkerman({M},{N}) = {Akkerman(M,N)}");

int Akkerman(int M, int N)
// Функция Аккермана
{
    if (M == 0) {return N+1; }
    else if (N == 0 && M > 0) {return Akkerman(M-1,1);}
    else {return Akkerman(M-1,Akkerman(M,N-1));}
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