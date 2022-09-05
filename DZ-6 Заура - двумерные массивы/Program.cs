// Программа показывает двумерный массив размером m*n, заполненный вещественными числами.
// Далее заполняет двумерный массив по следующему правилу A(m,n)=m+n.
// Потом заменяет элементы, у которых оба индекса чётные на их квадраты.
// Далее: преобразует массив в целочисленный и находит среднее арифметическое каждого из столбцов.
// Потом обменивает элементы первой строки и последней строки.
// Далее упорядочивает по убыванию элементы каждой строки двумерного массива.
// Потом заменяет строки на столбцы или сообщает, что это невозможно (в случае, если матрица не квадратная).
// И наконец находит строку с наименьшей суммой элементов.
using static System.Console;
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
double[,] arr = FillArrayTwodimDouble(row, column, -1000, 1000);
WriteLine($"Массив вещественных чисел {row}*{column}:");
PrintArrayTwodim(arr);
WriteLine();
FillArrayTwodimMN(ref arr);
WriteLine("Заполнение двумерного массива по правилу A(m,n)=m+n");
PrintArrayTwodim(arr);
WriteLine();
ReplaceToSquareChetIndexArrayTwodim(ref arr);
WriteLine("Замена элементов, у которых оба индекса чётные на их квадраты");
PrintArrayTwodim(arr);
WriteLine();
int[,] arrey = ConvertArrayTwodimToInt(arr);
double[] srArifmColumn = GetSrArifmColumnArray(arrey);
WriteLine("Средние арифметические столбцов:");
WriteLine(string.Join("  ", srArifmColumn));
//PrintArrayDouble(srArifmColumn);
WriteLine();
ExchangeFirstToLastRowArray(ref arrey);
WriteLine("Обмен элементов первой и последней строк");
PrintArrayTwodimInt(arrey);
WriteLine();
SortInDescendingRowArray(ref arrey);
WriteLine("Элементы в строках отсортированы по убыванию");
PrintArrayTwodimInt(arrey);
WriteLine();
if (row != column) { WriteLine("Матрица не квадратная - поменять строки на столбцы невозможно"); }
else
{
    ReplaceRowToColumn(ref arrey);
    WriteLine("Замена строк на столбцы");
    PrintArrayTwodimInt(arrey);
}
WriteLine();
int minSum=0;
int indexRow=0;
FindRowMinSum(ref arrey, ref minSum, ref indexRow);
int[] rowMinSum =new int[arrey.GetLength(1)];
for(int j=0;j<arrey.GetLength(1);j++) {rowMinSum[j]=arrey[indexRow,j];}
WriteLine($"Строка с наименьшей суммой элементов равной {minSum}");
WriteLine(string.Join("  ", rowMinSum));
WriteLine();

void FindRowMinSum(ref int[,] arr, ref int minSum, ref int indexRow)
// находит строку с наименьшей суммой элементов.
{
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
}

void ReplaceRowToColumn(ref int[,] arr)
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

void SortInDescendingRowArray(ref int[,] arr)
// упорядочивает по убыванию элементы каждой строки двумерного массива.
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
// сортирует целый массив от максимального к минимальному
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

void ExchangeFirstToLastRowArray(ref int[,] arr)
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

void ReplaceToSquareChetIndexArrayTwodim(ref double[,] arr)
// заменяет элементы, у которых оба индекса чётные на их квадраты.
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = Math.Pow(arr[i, j], 2);
        }
    }
}

void FillArrayTwodimMN(ref double[,] arr)
// заполняет двумерный массив по следующему правилу A(m,n)=m+n.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (i + 1) * (j + 1);
        }
    }
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
