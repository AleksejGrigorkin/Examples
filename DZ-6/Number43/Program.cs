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
if(k1==k2&& b1==b2) {WriteLine("Прямые совпадают");}
else if(k1==k2) {WriteLine("Прямые параллельны");}
else
{
    double[]point=FindPoint(k1,b1,k2,b2);
    WriteLine($"Точка пересечения заданных прямых: x = {point[0]}, y = {point[1]}");
}

double[] FindPoint(double k1, double b1, double k2, double b2)
// Расчёт точки пересечения прямых
{
    double[] point=new double[2];
    point[0]=(b2-b1)/(k1-k2);
    point[1]=k1*point[0]+b1;
    return point;
}

double InputDouble(string text)
// Вввод double числа
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
