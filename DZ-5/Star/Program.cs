// //Задача Star:
// //Программа задаёт одномерный массив заполненный случайными числами.
// //Далее из входного массива формирует массив с чётными и массив с нечётными значениями входного массива.
// //Потом находит ср. арифметическое из полученных значений элементов массивов.
// //И выводит результат сравнения ср. арифметических.
// using static System.Console;
// string text1 = "Введите количество элементов в массиве: ";
// string text2 = "Количество элементов должно быть больше нуля";
// int length = InputNaturalNumber(text1, text2);
// int[] arr = FillArray(length, 0, 9);
// int[] chet = new int[length];
// int[] nochet = new int[length];
// double[] srArifm = Separator(arr, chet, nochet);
// Array.Resize(ref chet, Convert.ToInt32(srArifm[2]));
// Array.Resize(ref nochet, Convert.ToInt32(srArifm[3]));
// WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
// WriteLine(string.Join(", ", arr));
// WriteLine("Массив " + Convert.ToString(chet.Length) + " чётных элементов: ");
// WriteLine(string.Join(", ", chet));
// WriteLine("Массив " + Convert.ToString(nochet.Length) + " нечётных элементов: ");
// WriteLine(string.Join(", ", nochet));
// if(srArifm[0]>srArifm[1])
// {
//     WriteLine($"Ср. арифметическое чётных {srArifm[0]} элементов больше, чем нечётных {srArifm[1]}");
// }
// else if(srArifm[0]<srArifm[1])
// {
//     WriteLine($"Ср. арифметическое чётных {srArifm[0]} элементов меньше, чем нечётных {srArifm[1]}");
// }
// else  {WriteLine($"Ср. арифметическое чётных и нечётных элементов равны {srArifm[0]}");}

// double[] Separator(int[] arr, int[] chet, int[] nochet)
// {
//     int sum1 = 0;
//     int sum2=0;
//     double[] srArifm = new double[4];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             sum1++;
//             chet[sum1-1]=arr[i];
//             srArifm[0]+=arr[i];
//         }
//         else
//         {
//             sum2++;
//             nochet[sum2-1]=arr[i];
//             srArifm[1]+=arr[i];
//         }
//     }
//     if(sum1!=0) {srArifm[0]=srArifm[0]/sum1;}
//     if(sum2!=0) {srArifm[1]=srArifm[1]/sum2;}
//     srArifm[2]=sum1;
//     srArifm[3]=sum2;
//     return srArifm;
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

// int[] FillArray(int length, int min, int max)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }




void fun(ref int x, ref int y)
    {
        x = 1;
        y = 2;
    }

        int x = 0;
        int y = 0;
 
        fun(ref x, ref y);
 
        Console.WriteLine($"x = {x}, y = {y}");


// using System;
 
// public class Example
// {
//     private static void fun(ref int x, ref int y)
//     {
//         x = 1;
//         y = 2;
//     }
 
//     public static void Main()
//     {
//         int x = 0;
//         int y = 0;
 
//         fun(ref x, ref y);
 
//         Console.WriteLine("x = {0}, y = {1}", x, y);
//     }
// }
