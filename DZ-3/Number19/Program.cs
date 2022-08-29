//Задача 19
//Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
int lenght=5;
bool isNumber = false; int x1=0;
while (!isNumber)
{
    Write($"Введите {lenght}-ти значное число: ");
    isNumber = int.TryParse(ReadLine(), out x1);
    if (!isNumber) {WriteLine("Это не число");}
    else if (x1 != Math.Abs(x1))
    {
        WriteLine("Отрицательное число не может быть палиандромом");
        isNumber = false;
    }
    else if(x1<(int)Math.Pow(10,lenght-1 )^x1>(int)Math.Pow(10,lenght)-1)
    {
        WriteLine($"Это не {lenght}-ти значное число");
        isNumber = false;
    }
}
int x2=ConvertInt(x1, lenght);
if(x1==x2) {WriteLine("Введёное число - палиандром");}
else {WriteLine("Введёное число - не палиандром");}

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