//Задача 35:
//Программа генерирует одномерный массив из 123 случайных чмсел.
//И находит количество элементов массива, значения которых лежат в отрезке [10, 99].
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int Min=-1000;
int Max=1000;
int length = InputNaturalNumber(text1, text2);
int first=Min-1;
int finish=Max+1;
while(first<Min) {first=InputInt($"Введте начало диапазона (больше {Min}): ");}
while(finish>Max) {finish=InputInt($"Введте конец диапазона (меньше {Max}): ");}
int[] arr = FillArray(length, Min, Max);
int sum=findNumbers(arr,first,finish);
WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
WriteLine(string.Join(", ", arr));
WriteLine($"Количество элементов массива, значения которых лежат в отрезке от {first} до {finish} равно: {sum}");

int findNumbers(int[] array,int first, int finish)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>=first&&array[i]<=finish) {sum++;}
    }
    return sum;
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