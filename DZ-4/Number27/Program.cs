//Задача 27.
//Программа принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
int number = InputInt("Введите целое число: ");
int sumNum = SumNumber(Math.Abs(number));
WriteLine($"Сумма цифр числа {number} = {sumNum}");

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

int SumNumber(int num)
{
    int result = 0;
    while (num!=0)
    {
        result = result +num%10;
        num=num/10;
    }
    return result;
}
