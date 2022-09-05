// //Задача 40:
// //Программа принимает на вход три числа.
// //И определяет может ли существовать треугольник со сторонами такой длины.
// using static System.Console;
// string text1 = "Введите длину первой сторны треугольника: ";
// string text2 = "Длина должна быть больше нуля";
// int[] arr= new int[3];
// arr[0] = InputNaturalNumber(text1, text2);
// arr[1] = InputNaturalNumber(text1, text2);
// arr[2] = InputNaturalNumber(text1, text2);
// bool Yes=true;
// if(arr[0]>=(arr[1]+arr[2])) {Yes=false;}
// if(arr[1]>=(arr[0]+arr[2])) {Yes=false;}
// if(arr[2]>=(arr[1]+arr[0])) {Yes=false;}
// if(Yes==true) {WriteLine("Треугольник будет");}
// else {{WriteLine("Треугольник невозможен");}}


// int InputInt(string text)
// {
//     bool isNumber = false; int x = 0;
//     while (!isNumber)
//     {
//         Write(text);
//         isNumber = int.TryParse(ReadLine(), out x);
//         if (!isNumber) { WriteLine("Это не число"); }
//     }
//     return x;
// }

// int InputNaturalNumber(string text1, string text2)
// {
//     int num = -1;
//     while (num < 1)
//     {
//         num = InputInt(text1);
//         if (num < 1) { WriteLine(text2); }
//     }
//     return num;
// }


// //Задача 42:
// //Программа преобразовывает десятичное число в двоичное
// using static System.Console;
// string text1 = "Введите целое десятичное число: ";
// string text2 = "Длина должна быть больше нуля";
// int number = InputNaturalNumber(text1, text2);



// bool Yes=true;
// if(arr[0]>=(arr[1]+arr[2])) {Yes=false;}
// if(arr[1]>=(arr[0]+arr[2])) {Yes=false;}
// if(arr[2]>=(arr[1]+arr[0])) {Yes=false;}
// if(Yes==true) {WriteLine("Треугольник будет");}
// else {{WriteLine("Треугольник невозможен");}}


// int InputInt(string text)
// {
//     bool isNumber = false; int x = 0;
//     while (!isNumber)
//     {
//         Write(text);
//         isNumber = int.TryParse(ReadLine(), out x);
//         if (!isNumber) { WriteLine("Это не число"); }
//     }
//     return x;
// }

// int InputNaturalNumber(string text1, string text2)
// {
//     int num = -1;
//     while (num < 1)
//     {
//         num = InputInt(text1);
//         if (num < 1) { WriteLine(text2); }
//     }
//     return num;
// }


// int InputInt(string text)
// {
//     bool isNumber = false; int x = 0;
//     while (!isNumber)
//     {
//         Write(text);
//         isNumber = int.TryParse(ReadLine(), out x);
//         if (!isNumber) { WriteLine("Это не число"); }
//     }
//     return x;
// }

// int InputNaturalNumber(string text1, string text2)
// {
//     int num = -1;
//     while (num < 1)
//     {
//         num = InputInt(text1);
//         if (num < 1) { WriteLine(text2); }
//     }
//     return num;
// }


string? a = Console.ReadLine();
bool isNum1 = int.TryParse(a, out int a1);
string? b = Console.ReadLine();
bool isNum2 = int.TryParse(b, out int b1);
string? c = Console.ReadLine();
bool isNum3 = int.TryParse(c, out int c1);

if(isNum1 != true || isNum2 != true || isNum3 != true)
{
    Console.WriteLine("Введено не целое число");
    return;
}

void PrintAnswer(int a, int b, int c)

{
if(a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это НЕ треугольник");
}


}

PrintAnswer(a1, b1, c1);
