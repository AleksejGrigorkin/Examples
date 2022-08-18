Console.WriteLine("Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите число 1: ");
int number1=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
Console.Write("Введите число 2: ");
int number2=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
if(number1 >number2 )
{
    Console.WriteLine("Первое число больше второго");
}    
else if(number2>number1)
{
    Console.WriteLine("Второе число больше первого");
}
else
{
    Console.WriteLine("Числа равны");
}
