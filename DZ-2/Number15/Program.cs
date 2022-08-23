Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
home:
Console.Write("Введите номер дня недели: ");
int day=Convert.ToInt32 (Console.ReadLine ());
if(day ==6^day==7 )
{
    Console.WriteLine("Выходной");
}    
else if(day <1^day>7 )
{
    Console.WriteLine("Вы ошиблись");
    goto home;
}
else
{
    Console.WriteLine("Рабочий");
}
