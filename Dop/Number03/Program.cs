//Задание:
// Найдите ближайшее значение к переданному.
// Вам даны список значений в виде массива и значение, относительно которого, надо найти ближайшее.

// Например, мы имеем следующий ряд чисел: 4, 7, 10, 11, 12, 17. И нам нужно найти ближайшее значение к цифре 9.
//Если отсортировать этот ряд по возрастанию, то слева от 9 будет 7, а справа 10. Но 10 - находится ближе, чем 7,
//значит правильный ответ 10.

// Несколько уточнений:
//  - Если 2 числа находятся на одинаковом расстоянии - необходимо выбрать наименьшее из них;
//  - Ряд чисел всегда не пустой, т.е. размер >= 1;
//  - Переданное значение может быть в этом ряде, а значит оно и является ответом;
//  - В ряде могут быть как положительные, так и отрицательные числа, но они всегда целые;
//  - Ряд не отсортирован и состоит из уникальных чисел.
// Входные данные: Два аргумента. Ряд значений в виде массива. Искомое значение - int 
//
using static System.Console;
string str = InputString("Введите в строку значения элементов массива целых чисел, разделяя их пробелами: ");
string[] Str = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int A = InputInt("Введите целое число, ближайшее к которому надо искать: ");
int length=Str.Length;
int count=0;
int x;
int[] num=new int[length];
foreach (string s in Str)
{
    bool isNumber = int.TryParse(s, out x);
    if (isNumber)
    {
        num[count]=x;
        count++;
    }
}
int deltaMin=Math.Abs(A-num[0]);
int min=num[0];
for(int i=1;i<count;i++)
{
    int delta=Math.Abs(A-num[i]);
    if(delta==0)
    {
        min=A;
        break;
    }
    else if(delta<deltaMin)
    {
        min=num[i];
        deltaMin=delta;
    }
    else if(delta==deltaMin)
    {
        if(num[i]<min)
        {
            min=num[i];
            deltaMin=delta;;
        }
    }
}
if(count==0) {WriteLine("В исходной строке нет целых чисел");}
else {WriteLine($"Ближайшее к {A} среди элементов массива равно {min}");}

string InputString(string text)
{
    string? x = null;
    while (x==null||x=="")
    {
        Write(text);
        x = ReadLine();
        if (x=="") { WriteLine("Значение не должно быть пустым"); }
    }
    return x;
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