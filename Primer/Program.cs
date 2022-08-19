Console.Write("Введите число 1: ");
int number1=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
Console.Write("Введите число 2: ");
int number2=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
int result=number2*number2;
if(result ==number1 )
{
    Console.WriteLine("Второе число является квадратом первого");
}    
else 
{
    Console.WriteLine("Второе число НЕ является квадратом первого");
}


Console.Write("Введите номер дня недели: ");
int day=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число

if(day ==1 )
{
    Console.WriteLine("Понедельник");
}    
else if(day ==2 )
{
    Console.WriteLine("Вторник");
}
else if(day ==3 )
{
    Console.WriteLine("Среда");
}
else if(day ==4 )
{
    Console.WriteLine("Четверг");
}
else if(day ==5 )
{
    Console.WriteLine("Пятница");
}
else if(day ==6 )
{
    Console.WriteLine("Суббота");
}
else if(day ==7 )
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Вы ошиблись");
}




Console.Write("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int N1 = -N;

while (N1 <= N)
{
    Console.WriteLine(N1);
        N1 = N1 + 1;
}


Console.Write("Введите трёхзначное число: ");
int m = Convert.ToInt32(Console.ReadLine());

int last_number = m%10;

Console.WriteLine(last_number);
