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
//         if(array[i] > 0)
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
//     Console.WriteLine("]");
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
