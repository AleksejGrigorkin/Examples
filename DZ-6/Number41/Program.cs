// Задача 41:  Вариант строго по заданию.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using static System.Console;
string text="финиш";
WriteLine("Вводите целые числа по одному, как закончите, введите "+text+": ");
int num = CheckFinish(text);
WriteLine($"Чисел больше нуля введено {num}");

int CheckFinish(string text)
{
    int num = -1;
    int count=0;
    int index=0;
    bool isNumber = false;
    string? stop="";
    while (stop!=text)
    {
        Write($"Ведите число номер {index+1}: ");
        stop=ReadLine();
        if(stop!=text)
        {
            isNumber = int.TryParse(stop, out num);
            if (!isNumber) { WriteLine("Это не число"); }
            else
            {
                index++;
                if(num>0) {count++;}
            }
        }
    }
    return count;
}
