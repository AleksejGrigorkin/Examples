// home:
// Console.WriteLine("введите x");
// bool isNumberX=int.TryParse(Console.ReadLine (), out int x);
// Console.WriteLine("введите y");
// bool isNumberY=int.TryParse(Console.ReadLine (), out int y);
// if(isNumberX !=true||isNumberY !=true)
// {
//     Console.WriteLine("Число не верно");
//     goto home;
// }
// int GetPosition(int x, int y)
// {
//     if(x>0&&y>0)
//     {
//         return 1;
//     }
//     if(x<0&&y>0)
//     {
//         return 2;
//     }
//     if(x<0&&y<0)
//     {
//         return 3;
//     }
//     if(x>0&&y<0)
//     {
//         return 4;
//     }
//     return 0;
// }
// if (GetPosition(x, y)==0)
// {
//     Console.WriteLine("x или y равны нулю");
// }
// else
// {
//     Console.WriteLine(GetPosition(x, y)+" четверть");
// }


// // Задача 18
// home:
// Console.WriteLine("введите номер четверти");
// bool isNumberX=int.TryParse(Console.ReadLine (), out int x);
// string result="";
// if(isNumberX !=true)
// {
//     Console.WriteLine("Это не чмсло");
//     goto home;
// }
// else if(x<1^x>4)
// {
//     Console.WriteLine("Четвертей всего 4");
//     goto home;
// }
// string GetPosition(int x)
// {
//     if(x==1)
//     {
//         return result="x>0, y>0";
//     }
//     if(x==2)
//     {
//         return result ="x<0, y>0";
//     }
//     if(x==3)
//     {
//         return result ="x<0, y<0";
//     }
//     return result ="x>0, y>0";
// }
// Console.WriteLine(GetPosition(x));


// // Задача 21
// using static System.Console;
// home:
// Write("Введите координату x первой точки: ");
// bool isNumberX1=int.TryParse(ReadLine (), out int x1);
// Write("Введите координату y первой точки: ");
// bool isNumberY1=int.TryParse(ReadLine (), out int y1);
// Write("Введите координату x второй точки: ");
// bool isNumberX2=int.TryParse(ReadLine (), out int x2);
// Write("Введите координату y второй точки: ");
// bool isNumberY2=int.TryParse(ReadLine (), out int y2);
// if(!isNumberX1||!isNumberY1||!isNumberX1||!isNumberY1)
// {
//     Console.WriteLine("Это не число");
//     goto home;
// }
// WriteLine($"Расстояние между точками {GetDlina(x1, y1, x2, y2)}");

// double GetDlina(int x1, int y1, int x2, int y2)
// {
//     double result=Math.Sqrt((int)Math.Pow((x2-x1), 2)+(int)Math.Pow((y2-y1), 2));
//     return result ;
// }


//Задача 22
using static System.Console;
home:
Write("Введите число: ");
bool isNumberX1 = int.TryParse(ReadLine(), out int x1);
if (!isNumberX1)
{
    Console.WriteLine("Это не число");
    goto home;
}
int x2 = Math.Abs(x1);
int[] arrey = new int[x2];
arrey = GetTab(x2);
Write(arrey[0]);
for (int i = 1; i < x2; i++)
{
    Write($", {arrey[i]}");
}


int[] GetTab(int x2)
{
    int[] arrey = new int[x2];
    for (int i = 1; i < x2 + 1; i++)
    {
        arrey[i - 1] = i * i;
    }
    return arrey;
}