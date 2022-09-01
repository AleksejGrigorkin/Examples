//Программа принимает на вход строку, состоящую только из цифр. Выдаёт количество нулей ("0") в начале строки.
using static System.Console;
string StrNum = InputString("Введите строку из цифр: ");
string StrNumVar=StrNum;
int length=StrNumVar.Length;
int sum=0;
while(StrNumVar.Substring(0,1)=="0")
{
    sum=sum+1;
    if(sum==length) {break;}
    StrNumVar=StrNumVar.Substring(1);
}
WriteLine($"Вначале строки нулей: {sum} ");

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
