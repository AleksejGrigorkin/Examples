// Задача 53.
// Ппрограмма генерирует двумерный целочисленный массив.
// Потом обменивает элементы первой строки и последней строки.
// Задача 66.
// Потом заменяет строки на столбцы или сообщает, что это невозможно
// (в случае, если матрица не квадратная).
using static System.Console;
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
int[,] array=Fill2DIntArray(row, column, 0, 10);
WriteLine($"Массив вещественных чисел {row}*{column}:");
PrintArrayTwodimInt(array);
WriteLine();
ExchangeFirstToLastRowArray(array);
WriteLine("Обмен элементов первой и последней строк");
PrintArrayTwodimInt(array);
WriteLine();
if (row != column) { WriteLine("Матрица не квадратная - поменять строки на столбцы невозможно"); }
else
{
    ReplaceRowToColumn(array);
    WriteLine("Замена строк на столбцы");
    PrintArrayTwodimInt(array);
}
WriteLine();
int[,] dictionary=CreateFrequencyDictionary2DIntArray(array);
WriteLine("частотный словарь элементов массива");
PrintArrayTwodimInt(dictionary);
WriteLine();
// int[,] arrReduced=DeleteRowCollumnMinElement2DIntArray(array);
// WriteLine("новый массив");
// PrintArrayTwodimInt(dictionary);
// WriteLine();

// int[,] DeleteRowCollumnMinElement2DIntArray(int[,] arr)
// // удаляет строку и столбец, на которых расположен минимальный элемент массива.
// {
//     int[,] arrReduced=new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {

//         }
//     }
//     return dictionary;
// }

int[,] CreateFrequencyDictionary2DIntArray(int[,] arr)
// составляет частотный словарь элементов массива.
{
    int[,] dictionary=new int[arr.Length,2];
    int count=1;
    // int flag=0;
    dictionary[0,0]=arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int flag=0;
            for(int k=0;k<count;k++)
            {
                if(dictionary[k,0]==arr[i,j])
                {
                    dictionary[k,1]++;
                    k=count;
                    flag=1;
                }
            }
            if(flag!=1)
            {
                dictionary[count,0]=arr[i,j];
                dictionary[count,1]++;
                count++;
            }
            //flag=0;
        }
    }
    return dictionary;
}

void ReplaceRowToColumn(int[,] arr)
// заменяет строки на столбцы или сообщает, что это невозможно
// (в случае, если матрица не квадратная).
{
    int tmp;
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
}

void ExchangeFirstToLastRowArray(int[,] arr)
// обменивает элементы первой и последней строк.
{
    int tmp;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        tmp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = tmp;
    }
}

void PrintArrayTwodimInt(int[,] arr)
// Вывод на экран двумерного целочисленного массива.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]}  ");
        }
        WriteLine();
    }
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

int[,] Fill2DIntArray(int row, int column, int min, int max)
// Создаёт двумерный массив и заполняет его случайными целыми числами.
{
    int[,] array = new int[row, column];
    Random random = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(min,max+1);
        }
    }
    return array;
}