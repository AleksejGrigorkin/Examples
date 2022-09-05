// Задача 43:
// Программа находит точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using static System.Console;
WriteLine("y = k1 * x + b1");
WriteLine("y = k2 * x + b2");
double k1=InputDouble("Введите k1: ");
double b1=InputDouble("Введите b1: ");
double k2=InputDouble("Введите k2: ");
double b2=InputDouble("Введите b2: ");
if(k1==k2) {WriteLine("Прямые параллельны");}
else
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    WriteLine($"Точка пересечения заданных прямых: x = {x}, y = {y}");
}

double InputDouble(string text)
{
    bool isNumber = false; double x = 0;
    while (!isNumber)
    {
        Write(text);
        isNumber = double.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}
