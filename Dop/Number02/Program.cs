//Програсса получает на вход строку символов. Разделяет её на массив строк по два символа.
//Если строка содержит нечетное количество символов, добавляется "_" - второй символ последней пары.
//Длина строки от 0 до 100 символов.
using static System.Console;
string Str = InputStringMod("Введите строку до 100 символов: ");
string StrVar=Str;
int length=StrVar.Length;
if (length%2!=0) {StrVar=StrVar+"_";}
length=(length+1)/2;
string[] s=new string[length];
for(int i=0;i<length;i++)
{
    s[i]=StrVar.Substring(0,2);
    StrVar=StrVar.Substring(2);
}
WriteLine(string.Join(", ", s));

string InputStringMod(string text)
{
    string? x = null;
    while (x==null||x.Length>100)
    {
        Write(text);
        x = ReadLine();
        if (x.Length>100) { WriteLine("Слишком длинная строка"); }
    }
    return x;
}
