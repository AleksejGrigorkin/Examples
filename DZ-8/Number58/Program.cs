//Задача 58:
// Программа генерирует две целочисленных матрицы.И перемножает их.
using static System.Console;
string text1 = "Введите количество строк в первой матрице: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в первой матрице: ";
int column1 = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов во второй матрице: ";
int column2 = InputNaturalNumber(text1, text2);
int[,] A = Fill2DIntArray(row, column1, 0, 10);
int[,] B = Fill2DIntArray(column1, column2, 0, 10);
WriteLine($"Матрицв A {row}*{column1}:");
Print2DIntArray(A);
WriteLine();
WriteLine($"Матрицв B {column1}*{column2}:");
Print2DIntArray(B);
WriteLine();
int[,] C=CompositinAB(A,B);
WriteLine($"Матрицв C[{column1}, {column2}] = A*B:");
Print2DIntArray(C);
WriteLine();


int[,] CompositinAB(int[,] A,int[,] B)
// Произведение матриц C=A*B
{
    int row=A.GetLength(0);
    int column=B.GetLength(1);
    int[,] C=new int[row,column];
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<column;j++)
        {
            for(int k=0;k<A.GetLength(1);k++)
            {
                C[i,j]+=A[i,k]*B[k,j];
            }
        }
    }
    return C;
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
