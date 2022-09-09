// Задача 52.
// Программа генерирует массив целоых чисел и находит среднее арифметическое каждого из столбцов.
//
// Для генерации входного массива, воспользуемся, например, программой к задаче 47.
// Затем конвертируем его в целый.
using static System.Console;
double[,] array = GenMNDoubleArr();
int[,] intArray = ConvertArrayTwodimToInt(array);
WriteLine();
WriteLine($"Массив целых чисел {intArray.GetLength(0)}*{intArray.GetLength(1)}:");
PrintArrayTwodimInt(intArray);
double[] srArifmColumn = GetSrArifmColumnArray(intArray);
WriteLine("Средние арифметические столбцов:");
WriteLine(string.Join("  ", srArifmColumn));
WriteLine();

double[,] GenMNDoubleArr()
// Задача 47.
// Программа показывает двумерный массив размером m*n, заполненный вещественными числами.
{
    string text1 = "Введите количество строк в массиве: ";
    string text2 = "Количество элементов должно быть больше нуля";
    int row = InputNaturalNumber(text1, text2);
    text1 = "Введите количество столбцов в массиве: ";
    int column = InputNaturalNumber(text1, text2);
    double[,] arr = FillArrayTwodimDouble(row, column, -1000, 1000);
    WriteLine();
    WriteLine($"Массив вещественных чисел {row}*{column}:");
    PrintArrayTwodim(arr);
    return arr;
}

double[] GetSrArifmColumnArray(int[,] arr)
// находит среднее арифметическое каждого из столбцов.
{
    double[] array = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            array[j] += arr[i, j];
        }
        array[j] /= arr.GetLength(0);
    }
    return array;
}

int[,] ConvertArrayTwodimToInt(double[,] arr)
// преобразует массив в целочисленный
{
    int[,] arrey = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrey[i, j] = Convert.ToInt32(arr[i, j]);
        }
    }
    return arrey;
}

double[,] FillArrayTwodimDouble(int row, int column, double min, double max)
// Создаёт двумерный массив и заполняет его случайными double числами.
{
    double[,] array = new double[row, column];
    Random random = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.NextDouble() * (max - min) + min;
        }
    }
    return array;
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

void PrintArrayTwodim(double[,] arr)
// Вывод на экран двумерного double массива.
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
