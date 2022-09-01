//Задача 38:
//Программа задаёт массив вещественных чисел.
//И находит разницу между максимальным и минимальным значениями элементов массива.
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
double[] arr = FillArrayDouble(length, -1000, 1000);
double Max=GetMaxDouble(arr);
double Min=GetMinDouble(arr);
double delta = Max-Min;
WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
WriteLine(string.Join(", ", arr));
WriteLine($"Разница между максимальным и минимальным значениями элементов массива равна: {delta}");

double GetMaxDouble(double[] arr)
{
    double Max=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] >Max) { Max=arr[i]; }
    }
    return Max;
}

double GetMinDouble(double[] arr)
{
    double Min=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] <Min) { Min=arr[i]; }
    }
    return Min;
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

double[] FillArrayDouble(int length, double min, double max)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.NextDouble()*(max-min)+min;
    }
    return array;
}
