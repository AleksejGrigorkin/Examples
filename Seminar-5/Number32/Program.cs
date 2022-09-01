//Задача 32:
//Программа меняет знак элементов массива
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
int[] arr = FillArray(length, -9, 9);
int[] invarray=InvertArray(arr);
WriteLine("Исходный массив: ");
WriteLine(string.Join(", ", arr));
WriteLine("Массив - результат:");
WriteLine(string.Join(", ", invarray));

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

int[] InvertArray(int[] array)
{
    int length=array.Length;
    int[] invarray = new int[length];
    for (int i = 0; i < length; i++)
    {
        invarray[i]=-1*array[i];
    }
    return invarray;
}

int[] FillArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
