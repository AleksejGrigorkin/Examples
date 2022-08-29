

// using static System.Console;
// //int lenght=5;
// bool isNumber = false; int x1=0;
// while (!isNumber)
// {
//     Write($"Введите число: ");
//     isNumber = int.TryParse(ReadLine(), out x1);
//     if (!isNumber) {WriteLine("Это не число");}
//     else if (x1 != Math.Abs(x1))
//     {
//         WriteLine("Отрицательное число не может быть палиандромом");
//         isNumber = false;
//     }
// }
// int x2=ConvertInt(x1);
// WriteLine(x2);

// int ConvertInt(int x)
// {
//     int x2=0;
//     for(int i=1;i<=x; i++)
//     {
//         x2=x2+i;
//     }
//     return x2;
// }


////Задача 26
////Программа принимает на вход число и выдаёт количество цифр в числе
// using static System.Console;
// int x2;
// bool isNumber = false; int x1=0;
// while (!isNumber)
// {
//     Write($"Введите число: ");
//     isNumber = int.TryParse(ReadLine(), out x1);
//     if (!isNumber) {WriteLine("Это не число");}
// }
//     if (x1 != 0) {x2=CountNumber(x1);}
//     else {x2=1;}
// WriteLine(x2);

// int CountNumber(int x)
// {
//     int x2=0;
//     while(x!=0)
//     {
//         x=x/10;
//         x2++;
//     }
//     return x2;
// }

//Задача 28
//Программа на вход принимает число N и выдаёт произведение чисел от 1 до N
using static System.Console;
int x2;
bool isNumber = false; int x1=0;
while (!isNumber)
{
    Write($"Введите число: ");
    isNumber = int.TryParse(ReadLine(), out x1);
    if (!isNumber) {WriteLine("Это не число");}
}
    if (x1 > 0) {x2=GetFactorial(x1);}
    else {x2=0;}
WriteLine(x2);

int GetFactorial(int x)
{
    int x2=1;
    for(int i=1;i<=x;i++) {x2=x2*i;}
    return x2;
}



////Задача 30
////Программа выводит массив элементов из 6 элементов,
////заполненный 0 и 1 в случайном порядке
// using static System.Console;
// int N=8;
// int[] arr=new int[N];
// Random rand=new Random();
// for(int i=0;i<N;i++)
// {
//     arr[i]=rand.Next(0,2);
//     Write($"{arr[i]} ");
// }
// WriteLine();
