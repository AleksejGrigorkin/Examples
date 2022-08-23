// С использованием метода
Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число: ");
string str = Console.ReadLine();
if (int.Parse (str)/100 == 0)
{
    Console.WriteLine("В этом числе нет третьей цифры.");
}
else
{
    Console.WriteLine($"Третья цифра {FindNumberThree(str, 3)}");
}


int FindNumberThree(string str, int index)
{
    int number = Convert.ToInt32(new string( str[index - 1], 1));
    return number;
}



// Минималистский вариант
// string str = Console.ReadLine();
// if (str.Length < 3) Console.WriteLine("В этом числе нет третьей цифры.");
// else Console.WriteLine($"Третья цифра {Convert.ToInt32(new string( str[2], 1))}");

