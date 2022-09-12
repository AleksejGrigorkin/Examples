// Задача со звёздочкой.
// Программа генерирует массив из n элементов.
// Потом сдвинает элементы массива влево, или вправо на 1 позицию.
using static System.Console;
string text1 = "Введите количество элементов в массиве: ";
string text2 = "Количество элементов должно быть больше нуля";
int length = InputNaturalNumber(text1, text2);
double[] arr = FillArrayDouble(length, -1000, 1000);
WriteLine("Массив " + Convert.ToString(length) + " элементов: ");
WriteLine(string.Join(", ", arr));
WriteLine();
ShiftToLeft(arr);
WriteLine("Смещение элементов массива влево: ");
WriteLine(string.Join(", ", arr));
WriteLine();
ShiftToRight(arr);
ShiftToRight(arr);
WriteLine("Смещение элементов массива вправо: ");
WriteLine(string.Join(", ", arr));
WriteLine();

void ShiftToLeft(double[] arr)
// Смещение элементов массива влево
{
    int last=arr.Length-1;
    double tmp=arr[0];
    for(int i=0;i<last;i++){arr[i]=arr[i+1];}
    arr[last]=tmp;
}

void ShiftToRight(double[] arr)
// Смещение элементов массива вправо
{
    int last=arr.Length-1;
    double tmp=arr[arr.Length-1];
    for(int i=0;i<last;i++){arr[last-i]=arr[last-i-1];}
    arr[0]=tmp;
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

double[] FillArrayDouble(int length, double min, double max)
// Создание массива и заполнение его случайными double числами
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.NextDouble()*(max-min)+min;
    }
    return array;
}
