//Задачв 25.
//Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Через цикл с числами.

using static System.Console;
int A = InputInt("Введите целое число A: ");
int B=InputNaturalNumber("Введите натуральное число B: ");
int result = CalculateToDegree(A, B);
WriteLine($"{A} в степени {B} = {result}");

int InputNaturalNumber(string text)
{
    int num = -1;
    while (num < 1)
    {
        num = InputInt(text);
        if (num < 1) { WriteLine("Это не натуральное число"); }
    }
    return num;
}

int InputInt(string text)
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

int CalculateToDegree(int num, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result = result * num;
    }
    return result;
}
