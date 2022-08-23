// Без использования метода - нафиг он тут нужен
// Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
// home:
// Console.Write("Введите номер дня недели: ");
// int day=Convert.ToInt32 (Console.ReadLine ());
// if(day ==6^day==7 )
// {
//     Console.WriteLine("Выходной");
// }    
// else if(day <1^day>7 )
// {
//     Console.WriteLine("Вы ошиблись");
//     goto home;
// }
// else
// {
//     Console.WriteLine("Рабочий");
// }


//С использованием метода - но это всё усложняет
Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
home:
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (FindWeekend(day) == true)
{
    Console.WriteLine("Выходной");
}
else if (FindMistake(day) == true)
{
    Console.WriteLine("Вы ошиблись");
    goto home;
}
else
{
    Console.WriteLine("Рабочий");
}

bool FindWeekend(int day)
{
    bool Day = day == 6 ^ day == 7;
    return Day;
}

bool FindMistake(int day)
{
    bool Day = day < 1 ^ day > 7;
    return Day;
}

//минималистский
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 6 ^ day == 7) Console.WriteLine("Выходной");

