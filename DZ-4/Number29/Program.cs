////Задача 29.
// //Программа задаёт массив из 8 элементов и выводит их на экран.
////Вариант - массив -целый.
// using static System.Console;
// string text1="Введите количество элементов в массиве: ";
// string text2="Количество элементов должно быть больше нуля";
// int col = InputNaturalNumber(text1, text2);
// int[] arr=new int[col];
// for(int i=0;i<col;i++)
// {
//     arr[i]=InputInt($"Введите значение {i+1} элемента массива: ");
// }
// WriteArrey("Массив "+Convert.ToString(col)+" элементов: ", arr, col);

// void WriteArrey(string text, int[] arrey, int n)
// {
//     WriteLine(text);
//     Write(arrey[0]);
//     for (int i = 1; i < n; i++)
//     {
//         Write($", {arrey[i]}");
//     }
//     WriteLine();
// }

// int InputNaturalNumber(string text1, string text2)
// {
//     int num = -1;
//     while (num < 1)
//     {
//         num = InputInt(text1);
//         if (num < 1) { WriteLine(text2); }
//     }
//     return num;
// }

// int InputInt(string text)
// {
//     bool isNumber = false; int x = 0;
//     while (!isNumber)
//     {
//         Write(text);
//         isNumber = int.TryParse(ReadLine(), out x);
//         if (!isNumber) { WriteLine("Это не число"); }
//     }
//     return x;
// }

//Задача 29.
//Программа задаёт массив из 8 элементов и выводит их на экран.
//Вариант - массив -string.
using static System.Console;
string text1="Введите количество элементов в массиве: ";
string text2="Количество элементов должно быть больше нуля";
int col = InputNaturalNumber(text1, text2);
string[] arr=new string[col];
for(int i=0;i<col;i++)
{
    arr[i]=InputString($"Введите значение {i+1} элемента массива: ");
}
WriteLine("Массив "+Convert.ToString(col)+" элементов: ");
WriteLine(string.Join(", ", arr));
// WriteStringArrey("Массив "+Convert.ToString(col)+" элементов: ", arr, col);

// void WriteStringArrey(string text, string [] arrey, int n)
// {
//     WriteLine(text);
//     Write(arrey[0]);
//     for (int i = 1; i < n; i++)
//     {
//         Write($", {arrey[i]}");
//     }
//     WriteLine();
// }

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

