// Задача 62.
// Программа заполняет спирально квадратный массив целыми,
// возрастающими попорядку числами, начиная с 10.
using static System.Console;
string text1 = "Введите размер квадратного массива: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
int[,] arr = Fill2DIntArraySpiral(row, 10);
WriteLine("Квадратный массив целыхых чисел, заполненный спирально по возрастанию:");
Print2DIntArray(arr);
WriteLine();


int[,] Fill2DIntArraySpiral(int lenght, int min)
// Создаёт квадратный массив и заполняет его по спирали целыми возрастающими числами.
{
    int[,] array = new int[lenght, lenght];
    int i=0;
    int row=lenght-1;
    while(row>i)
    {
        for (int j = i; j < row; j++)
        {
            array[i,j]=min;
            array[j,row]=min+row-i;
            array[row,row+i-j]=min+(row-i)*2;
            array[row+i-j,i]=min+(row-i)*3;
            min++;
        }
        min+=(row-i)*3;
        i++;
        row--;
    }
    if(row==i)
    {
        array[i,row]=min;
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
