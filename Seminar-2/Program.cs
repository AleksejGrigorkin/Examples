/*Random random = new Random();
int randomnumber= random.Next (10,100);
Console.WriteLine(randomnumber);

int lastnumber = randomnumber %10;
int firstnumber=randomnumber /10;
Console.WriteLine(lastnumber);
Console.WriteLine(firstnumber);
// Console.Write("Максимальное число равно ");
if(lastnumber >firstnumber )
{
    Console.WriteLine($"Максимальное число равно {lastnumber}");
}
else 
{
    Console.WriteLine($"Максимальное число равно {firstnumber}");
}
*/

// int GetMaxNumber(int number)
// {
//     int lastnumber = number % 10;
//     int firstnumber = number / 10;
//     if (lastnumber > firstnumber)
//     {
//         return lastnumber;
//     }
//     else
//     {
//         return firstnumber;
//     }
// }

// Random random = new Random();
// int randomnumber = random.Next(10, 100);
// int result = GetMaxNumber(randomnumber);
// Console.WriteLine(result);



// Console.WriteLine("Программа выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");
// Random random = new Random();
// int randomnumber= random.Next (100,1000);
// Console.WriteLine(randomnumber);
// int lastnumber = randomnumber %10;
// int firstnumber=randomnumber /100;
// int result=firstnumber*10+lastnumber;
// Console.WriteLine($"Получаем {result}");


/*
Console.WriteLine("Программа принимает на вход два числа и проверяет, является ли второе кратным первому. Если нет - выводит остаток от деления.");
Console.Write("Введите первое число: ");
int number1=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
Console.Write("Введите второе число: ");
int number2=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
int result =number1 %number2 ;
if(result ==0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
*/


/*
Console.WriteLine("Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
Console.Write("Введите число: ");
int number=Convert.ToInt32 (Console.ReadLine ()); // Конвертация в число
int result1 =number %7 ;
int result2 =number %23 ;
if(result1 ==0)
{
    if(result2 ==0)
    Console.WriteLine("Да. Кратно и 7 и 23");
}
else 
{
    Console.WriteLine("Нет. Одновременно не кратно числам 7 и 23");
}
*/


/*
Console.WriteLine("Программа принимает на вход два числа и проверяет, является ли одно квадратом другого.");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // Конвертация в число
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); // Конвертация в число
int result = number2 * number2;
if (result == number1)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    result = number1 * number1;
    if (result == number2)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Ни одно число НЕ является квадратом другого");
    }
}
*/