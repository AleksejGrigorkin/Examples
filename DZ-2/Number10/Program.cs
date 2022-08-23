// С использованием метода
Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
home:
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Конвертация в число
if (number / 100 == 0 ^ number / 100 > 9)
{
    Console.WriteLine("Вы ввели НЕ трёхзначное число:");
    goto home;
}
Console.WriteLine($"Вторая цифра {FindNumberTo(number)}");

int FindNumberTo(int number)
{
    int secondnumber = number / 10 % 10;
    return secondnumber;
}

// Минималистский вариант
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вторая цифра {number / 10 % 10}");
