//Задача 19
//Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
int lenght=5;
home:
Write($"Введите {lenght}-ти значное число: ");
bool isNumberX1 = int.TryParse(ReadLine(), out int x1);
if (!isNumberX1)
{
    WriteLine("Это не число");
    goto home;
}
else if (x1 != Math.Abs(x1))
{
    WriteLine("Отрицательное число не может быть палиандромом");
    goto home;
}
else if(x1<(int)Math.Pow(10,lenght-1 )^x1>(int)Math.Pow(10,lenght)-1)
{
    WriteLine($"Это не {lenght}-ти значное число");
    goto home;
}
int x2=ConvertInt(x1, lenght);
if(x1==x2)
{
    WriteLine("Введёное число - палиандром");
}
else 
{
    WriteLine("Введёное число - не палиандром");
}

int ConvertInt(int x, int lenght)
{
    int x2=0;
    for(int i=0;i<lenght; i++)
    {
        x2=x2+x%10*(int)Math.Pow(10,lenght -i-1);
        x=x/10;
    }
    return x2;
}