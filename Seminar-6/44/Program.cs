// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }


//Задача 45:
//Программа Считает числа Фибоначчи
using static System.Console;
string text1 = "Введите количество чисел Фибоначчи: ";
string text2 = "Количество элементов должно быть больше нуля";
int n = InputNaturalNumber(text1, text2);
double[] fibonacci=new double[n];
fibonacci=FibonacciSprint(n);
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"f({i}) = {fibonacci[i]}");
}

double[] FibonacciSprint(int n)
{
    double[] fibonacci=new double[n];
    for (int i = 0; i < n; i++)
    {
        if(i == 0 || i == 1) fibonacci[i]= i;
        else fibonacci[i]= fibonacci[i-1] + fibonacci[i-2];
    }
   return fibonacci; 
}

int InputNaturalNumber(string text1, string text2)
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
