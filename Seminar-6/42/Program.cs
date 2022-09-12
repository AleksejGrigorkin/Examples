//Задача 42:
//Программа преобразовывает десятичное число в друную систем счисления
using static System.Console;
string text1 = "Введите натуральное десятичное число: ";
string text2 = "Число должно быть больше нуля";
int number = InputNaturalNumber(text1, text2);
text1 = "Введите основание системы счисления: ";
int footing = InputNaturalNumber(text1, text2);
string convNum = ConvertNumberSystems(number, footing);
WriteLine(convNum);

string ConvertNumberSystems(int number, int footing)
{
    string result = "";
    while (number > 0)
    {
        int num = number % footing;
        string buf = Convert.ToString(num);
        if (num > 9) {buf = ReplacementToLetter(buf);}
        result = buf + result;
        number = number / footing;
    }
    return result;
}

string ReplacementToLetter(string buf)=> buf switch
{
        "10" => "A",
        "11" => "B",
        "12" => "C",
        "13" => "D",
        "14" => "E",
        "15" => "F",
        _ => "YYY"
};

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


//Console.WriteLine(Convert.ToString(45,16));
