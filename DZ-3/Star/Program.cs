// //программа на вход принимает радиус круга, находит его площадь округленную до целого числа.
// // Необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

// using static System.Console;
// int maxNumber=0;
// home:
// int r = InputNumber("Введите ", "радиус ", "круга: ");
// if (r <= 0) {WriteLine("Радиус не может быть меньше или равен нулю"); goto home;}
// else
// {
//     int S = Convert.ToInt32(Math.PI * r * r);
//     maxNumber=GetMaxNumber(S);
// }
// WriteLine($"Максимальная цифра в округлённой площади равна: {maxNumber}");

// int GetMaxNumber(int num)
// {
//     while(num!=0)
//     {
//         int s1=num%10;
//         if (maxNumber<s1) {maxNumber=s1;}
//         num=num/10;
//     }
//         return maxNumber;
// }

// int InputNumber(string a, string b, string c)
// {
//     bool isNumber = false; int x = 0;
//     while (!isNumber)
//     {
//         Write(a + b + c);
//         isNumber = int.TryParse(ReadLine(), out x);
//         if (!isNumber) { WriteLine("Это не число"); }
//     }
//     return x;
// }


//программа на вход принимает радиус круга, находит его площадь округленную до целого числа.
// Необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

using static System.Console;
string s; int r = 0;
while (r <= 0)
{
    r = InputNumber("Введите ", "радиус ", "круга: ");
    if (r <= 0) { WriteLine("Радиус не может быть меньше или равен нулю"); }
}
int S = Convert.ToInt32(Math.PI * r * r);
s = Convert.ToString(S);
WriteLine($"Максимальная цифра в округлённой площади равна: {s.Max()}");

int InputNumber(string a, string b, string c)
{
    bool isNumber = false; int x = 0;
    while (!isNumber)
    {
        Write(a + b + c);
        isNumber = int.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}


//программа на вход принимает радиус круга, находит его площадь округленную до целого числа.
// Необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

//Без проверок

// using static System.Console;
// Write("Введите радиус круга: ");
// int r = Convert.ToInt32(ReadLine());
// int S = Convert.ToInt32(Math.PI * r * r);
// string s = Convert.ToString(S);
// WriteLine($"Максимальная цифра в округлённой площади равна: {s.Max()}");




//программа на вход принимает радиус круга, находит его площадь округленную до целого числа.
// Необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// Супер-компакт

// using static System.Console;string s;int r=0;while(r<=0){r=I();}
// int S=Convert.ToInt32(Math.PI*r*r);s=Convert.ToString(S);Write(s.Max());
// int I(){bool N=false;int x=0;while(!N){N=int.TryParse(ReadLine(),out x);}return x;}

// using static System.Console;int r=Convert.ToInt32(ReadLine());
// int S=Convert.ToInt32(Math.PI*r*r);string s=Convert.ToString(S);Write(s.Max());


// string str="12345384";
// Console.WriteLine(str.Max());