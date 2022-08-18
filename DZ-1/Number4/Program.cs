Console.WriteLine("Программа принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите число 1: ");
int number1=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
Console.Write("Введите число 2: ");
int number2=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
Console.Write("Введите число 3: ");
int number3=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число

int max=number1;
if(number2>max )
{
    max=number2;
}    
if(number3>max)
{
    max=number3;
}
Console.Write("Максимальное из этих чисел равно ");
Console.WriteLine(max);
