// Задача 50.
// Программа на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//
// Для генерации входного массива, воспользуемся, например, программой к задаче 47.
using static System.Console;
double[,] array=GenMNDoubleArr();
int quantity=2;
string text="Ввелите через пробел позицию элемента двумерного массива: ";
int[] coord = InputCoord(quantity,text);
if(array.GetLength(0)>coord[0]&&array.GetLength(1)>coord[1])
{
    WriteLine($"array[{coord[0]},{coord[1]}]= {array[coord[0],coord[1]]}");
}
else {WriteLine($"Заданная позиция выходит за пределы массива");}
WriteLine();


int[] InputCoord(int quantity,string text)
// Ввод данных строкой с разделилением через пробел.
{
    bool isNumber = false;
    bool[] isCoord=new bool[quantity];
    int[] coord=new int[quantity];
    while (!isNumber)
    {
        WriteLine();
        Write(text);
        string? posit=ReadLine();
        if(posit==null) {posit="";}  //чтоб не ругался
        string[] position = posit.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if(position.Length<quantity) {WriteLine($"Надо ввести {quantity} значения");}
        else
        {
            bool isAll=true;
            for(int i=0;i<quantity;i++)
            {
                isCoord[i] = int.TryParse(position[i], out coord[i]);
                if(!isCoord[i]) {isAll=false;}
            }
            if(!isAll) { WriteLine("Позиция задана не верно, вероятно, не все числа"); }
            else
            {
                for(int i=0;i<quantity;i++) {if(coord[i]<0) {isAll=false;}}
                if(!isAll) { WriteLine("Позиции элементов не могут быть отрицательными"); }
                else {{isNumber=true;}}
            }
        }
    }
    return coord;
}

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
