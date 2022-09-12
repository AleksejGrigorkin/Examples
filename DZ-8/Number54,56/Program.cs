// Программа генерирует двумерный массив размером m*n, заполненный случайными целыми числами.
// Задача 54.
// Упорядочивает по убыванию элементы каждой строки двумерного массива.
// Задача 56.
// Находит строку с наименьшей суммой элементов.
using static System.Console;
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
int[,] arr = Fill2DIntArray(row, column, 0, 10);
WriteLine($"Массив целыхых чисел {row}*{column}:");
Print2DIntArray(arr);
WriteLine();
SortInDescendingRowArray(arr);
WriteLine("Элементы в строках отсортированы по убыванию");
Print2DIntArray(arr);
WriteLine();
int minSum=0;
int indexRow=0;
int[] rowMinSum= FindRowMinSum(arr, ref minSum, ref indexRow);
WriteLine($"Строка с наименьшей суммой элементов равной {minSum}");
WriteLine(string.Join("  ", rowMinSum));
WriteLine();

int[] FindRowMinSum(int[,] arr, ref int minSum, ref int indexRow)
// находит строку с наименьшей суммой элементов.
{
    int[] rowMinSum=new int[arr.GetLength(1)];
    indexRow=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum+= arr[i, j];
        }
        if(i==0) {minSum=sum;}
        else if(sum<minSum)
        {
            minSum=sum;
            indexRow=i;
        }
    }
    for(int j=0;j<arr.GetLength(1);j++)
    {
        rowMinSum[j]=arr[indexRow,j];
    }
    return rowMinSum;
}

void SortInDescendingRowArray(int[,] arr)
// упорядочивает по убыванию элементы каждой строки двумерного целочисленного массива.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] sortArray = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sortArray[j] = (arr[i, j]);
        }
        SelectionSortMax(sortArray);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            (arr[i, j]) = sortArray[j];
        }
    }
}

void SelectionSortMax(int[] arr)
// сортирует целочисленный массив от максимального к минимальному
{
    int count = arr.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (arr[maxPosition] < arr[j]) { maxPosition = j; }
        }
        int temp = arr[maxPosition];
        arr[maxPosition] = arr[i];
        arr[i] = temp;
    }
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

void Print2DIntArray(int[,] arr)
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
// Ввод натурального числа
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
// Ввод целого числа
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
