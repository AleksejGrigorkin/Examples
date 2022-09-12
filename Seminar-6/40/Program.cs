//Задача 40:
//Программа принимает на вход три числа.
//И определяет может ли существовать треугольник со сторонами такой длины.
using static System.Console;
string text2 = "Длина должна быть больше нуля";
int[] arr= new int[3];
for(int i=0;i<3;i++)
    arr[i] = InputNaturalNumber($"Введите длину {i+1} сторны треугольника: ", text2);
if(arr[0]+arr[1]>arr[2]&&arr[0]+arr[2]>arr[1]&&arr[1]+arr[2]>arr[0])
{
    WriteLine("Треугольник будет");
}
else {{WriteLine("Треугольник невозможен");}}


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


// using static System.Console;
// int a=int.Parse(ReadLine());
// int b=int.Parse(ReadLine());
// int c=int.Parse(ReadLine());
// if(a>0&&b>0&&c>0&&a+b>c&&a+c>b&&b+c>a) {WriteLine("Треугольник");}
// else {WriteLine("Неверные параметры");}