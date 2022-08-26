//Задача 21
//Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
int[] A = new int[3];
int[] B = new int[3];
string t = "Введите координату ";
string t1 = " первой точки: ";
A[0] = ReadNumber(t, "x", t1);
A[1] = ReadNumber(t, "y", t1);
A[2] = ReadNumber(t, "z", t1);
t1 = " второй точки: ";
B[0] = ReadNumber(t, "x", t1);
B[1] = ReadNumber(t, "y", t1);
B[2] = ReadNumber(t, "z", t1);

WriteLine($"Расстояние между точками {GetDlina(A, B)}");

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

double GetDlina(int[] A, int[] B)
{
    int X = (int)Math.Pow((B[0] - A[0]), 2);
    int Y = (int)Math.Pow((B[1] - A[1]), 2);
    int Z = (int)Math.Pow((B[2] - A[2]), 2);
    double result = Math.Sqrt(X + Y + Z);
    return result;
}
