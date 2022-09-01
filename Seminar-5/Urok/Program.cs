// #nullable disable
// //Задайте массив из 12 элементов, заполненный случайными числами из
// // промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.WriteLine("Enter length - ");



// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// PrintArray(array);

// int sumPositiveNumber = GetSumPositiveNumberInArray(array);

// Console.WriteLine($"sum Positive Number - {sumPositiveNumber}");

// int sumNegativeNumber = GetSumNegativeNumberInArray(array);

// Console.WriteLine($"sum negative Number - {sumNegativeNumber}");

// int GetSumNegativeNumberInArray(int[] array)
// {
//     int sumNegativeNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sumNegativeNumber += array[i];
//         }
//     }

//     return sumNegativeNumber;
// }



// int GetSumPositiveNumberInArray(int[] array)
// {
//     int sumPositiveNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0)
//         {
//          sumPositiveNumber += array[i];
//         }
//     }

//     return sumPositiveNumber;
// }





// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }


// #nullable disable
// //Задача 32
// //
// using static System.Console;
// Write("Введи размер сассива: ");
// bool isNumber = int.TryParse(ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// //PrintArray(array);
// int[] invarray=InvertArray(array);
// WriteLine(string.Join(", ", array));
// WriteLine(string.Join(", ", invarray));

// int[] InvertArray(int[] array)
// {
//     int length=array.Length;
//     int[] invarray = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         invarray[i]=-1*array[i];
//     }
//     return invarray;
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }

// //Задача 33
// //
// using static System.Console;
// Write("Введи размер сассива: ");
// bool isNumber = int.TryParse(ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     WriteLine("Invalid number");
//     return;
// }

// Write("Введи искомое число: ");
// isNumber = int.TryParse(ReadLine(), out int number);
// if (!isNumber)
// {
//     WriteLine("Invalid number");
//     return;
// }


// int[] array = FillArray(length);
// bool Yes=findNumber(array,number);
// WriteLine(Yes);

// bool findNumber(int[] array,int number)
// {
//     for (int i = 0; i < length; i++)
//     {
//         if(number==array[i])
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }



// //Задача 35
// //
// using static System.Console;
// Write("Введи размер сассива: ");
// bool isNumber = int.TryParse(ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     WriteLine("Invalid number");
//     return;
// }

// Write("Введи начало диапазона: ");
// isNumber = int.TryParse(ReadLine(), out int first);
// if (!isNumber)
// {
//     WriteLine("Invalid firct");
//     return;
// }
// Write("Введи конец диапазона: ");
// isNumber = int.TryParse(ReadLine(), out int finish);
// if (!isNumber)
// {
//     WriteLine("Invalid finish");
//     return;
// }

// int[] array = FillArray(length);
// int sum=findNumbers(array,first,finish);
// WriteLine(sum);

// int findNumbers(int[] array,int first, int finish)
// {
//     int sum=0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>=first&&array[i]<=finish)
//         {
//             sum++;
//         }
//     }
//     return sum;
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-1000, 1001);
//     }
//     return array;
// }


//Задача 37
//
using static System.Console;
Write("Введи размер сассива: ");
bool isNumber = int.TryParse(ReadLine(), out int length);
if (!isNumber || length <= 0)
{
    WriteLine("Invalid number");
    return;
}

int[] array = FillArray(length);
int[] priz=umnoz(array);
WriteLine(sum);

int[] umnoz(int[] arr)
{
    int 
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>=first&array[i]<=finish)
        {
            sum++;
        }
    }
    return sum;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-1000, 1001);
    }
    return array;
}