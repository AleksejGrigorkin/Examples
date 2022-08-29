// Console.WriteLine("Введите x");
// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// Console.WriteLine("Введите y");
// bool isNumberY= int.TryParse(Console.ReadLine(), out int y);

// if(isNumberX != true || isNumberY != true)
// {
//     Console.WriteLine("Числа введены не верно.");
//     return;
// }

// bool isValid = Validate(x,y);
// if(isValid == false)
// {
//  Console.WriteLine("Како-то число равно нулю");
//  return;
// }

// int result = GetPosition(x,y);
// Console.WriteLine(result);

// bool Validate(int x, int y)
// {
//     if(x == 0 || y == 0)
//     {
//         return false;
//     }
//     return true;
// }

// int GetPosition(int x, int y)
// {
//     if(x>0 && y>0)
//     {
//         return 1;
//     }

//     if(x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if(x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if(x > 0 && y < 0)
//     {
//         return 4;
//     }
    
//     return -1;
// }


Console.WriteLine("Введите число: ");
string number=Console.ReadLine() ?? "";
bool ValidateNumber(string number)
{
    bool isNumber = int.TryParse(number, out int n);
    bool rez=true ;
    if(!isNumber )
    {
        return false;
    }
    else if(n<100&&n>-100)
    {
        return false;
    }
    return rez;
}

char GetThirNumber(string n)
{
    if(n.Contains("-"))
    {
        return n[3];
    }
    return n[2];
}

bool isValid=ValidateNumber(number);
if(!isValid)
{
    Console.WriteLine("число введено не верно.");
    return ;
}
char result=GetThirNumber(number);
Console.WriteLine(result);
