//Задача 37:
//Программа генерирует одномерный массив. И находит произведение пар чисел.
//Пара - первый-последний, второй-предпоследний и т.д.
//Результат выводится в новый массив.
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
int[] arr = FillArray(length, -9, 9);
int[] priz = GetNewArr(arr);
WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
WriteLine(string.Join(", ", arr));
WriteLine("Новый массив: ");
WriteLine(string.Join(", ", priz));

int[] GetNewArr(int[] array)
{
    int len=array.Length;
    int newarrLength=(len+1)/2;
    int[] newarr=new int[newarrLength];
    for(int i=0;i<newarrLength;i++)
    {
        newarr[i]=array[i];
        if(i<len/2)
        {
            newarr[i]*=array[len-1-i];
        }
    }
    return newarr;
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
