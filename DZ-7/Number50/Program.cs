// Задача 50.
// Программа на вход принимает число и двумерный массив.
// Проверяет его наличие в массиве и возвращает индексы найденного элемента.
// Или сообщает, что такого элемента нет.
using static System.Console;
int[,] array=GenMNIntArr();
WriteLine();
int number = InputInt("Введите искомое число: ");
int[] coord= FindNumberIn2DIntArray(array,number);
if(coord[0]==-1) {WriteLine($"Заданного числа в массиве нет");}
else {WriteLine($"array[{coord[0]},{coord[1]}] = {number}");}
WriteLine();

int[] FindNumberIn2DIntArray(int[,] arr,int number)
// Ищет число и возвращает его координаты.
{
    int[] coord=new int[2];
    coord[0]=-1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(number==arr[i,j])
            {
                coord[0]=i;
                coord[1]=j;
            }
        }
    }
    return coord;
}

int[,] GenMNIntArr()
// Программа показывает двумерный массив размером m*n, заполненный целыми числами.
{
string text1 = "Введите количество строк в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int row = InputNaturalNumber(text1, text2);
text1 = "Введите количество столбцов в массиве: ";
int column = InputNaturalNumber(text1, text2);
int[,] arr = Fill2DIntArray(row, column, -1000, 1000);
WriteLine();
WriteLine($"Массив целых чисел {row}*{column}:");
Print2DIntArray(arr);
return arr;
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
            array[i, j] = random.Next(min, max+1);
        }
    }
    return array;
}

void Print2DIntArray(int[,] arr)
// Вывод на экран двумерного целого массива.
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
