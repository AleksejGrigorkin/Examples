// Задача 41:  Вариант с массивом и подсчётом после ввода.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
WriteLine("Вводите значения элементов массива по одному:");
int[] arr=new int[length];
for(int i=0;i<length;i++)
{
    arr[i] = InputInt("Ведите число номер " +Convert.ToString(i+1) +": ");
}
int count=GetNatural(arr);
WriteLine("Было введено: ");
WriteLine(string.Join(", ", arr));
WriteLine($"Чисел больше нуля введено {count}");

int GetNatural(int[] arr)
{
    int count=0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>0) {count++;}
    }
    return count;
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
