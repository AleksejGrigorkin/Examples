// Задачи 48, 49, 51
// Программа заполняет двумерный массив по следующему правилу A(m,n)=m+n.
// Потом заменяет элементы, у которых оба индекса чётные на их квадраты.
// Затем нахходит сумму элементов главной диагонали.
using static System.Console;
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
int[,] arr = new int[row, column];
FillArrayTwodimMNInt(arr);
WriteLine("Заполнение двумерного массива по правилу A(m,n)=m+n");
PrintArrayTwodimInt(arr);
WriteLine();
ReplaceToSquareChetIndexArrayTwodimInt(arr);
WriteLine("Замена элементов, у которых оба индекса чётные на их квадраты");
PrintArrayTwodimInt(arr);
WriteLine();
int sum = SumDiagArrayTwodimInt(arr);
WriteLine("Сумма элементов, находящихся на главной диагонали");
WriteLine($"sum= {sum}");
WriteLine();


int SumDiagArrayTwodimInt(int[,] arr)
// Сумма элементов, находящихся на главной диагонали.
{
    int sum = 0;
    int lenght = arr.GetLength(0);
    if (lenght > arr.GetLength(1))
    {
        lenght = arr.GetLength(1);
    }
    for (int i = 0; i < lenght; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

void ReplaceToSquareChetIndexArrayTwodimInt(int[,] arr)
// Заменяет элементы, у которых оба индекса чётные на их квадраты.
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
        }
    }
}

void FillArrayTwodimMNInt(int[,] arr)
// заполняет двумерный массив по следующему правилу A(m,n)=m+n.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
        }
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
