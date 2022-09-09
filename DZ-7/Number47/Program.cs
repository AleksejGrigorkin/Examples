// Задача 47.
// Программа показывает двумерный массив размером m*n, заполненный вещественными числами.
using static System.Console;
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
double[,] arr = FillArrayTwodimDouble(row, column, -1000, 1000);
WriteLine($"Массив вещественных чисел {row}*{column}:");
PrintArrayTwodim(arr);

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
