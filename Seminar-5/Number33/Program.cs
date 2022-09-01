//Задача 33:
//Программа генерирует массив.
//И определяет присутствует ли заданное число в массиве.
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
int number=InputInt("Введите искомое число: ");
int[] arr = FillArray(length, -9, 9);
bool Yes=findNumber(arr,number);
WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
WriteLine(string.Join(", ", arr));
WriteLine($"Наличие числа {number} в массиве: {Yes}");

bool findNumber(int[] array,int number)
{
    for (int i = 0; i < length; i++)
    {
        if(number==array[i])
        {
            return true;
        }
    }
    return false;
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