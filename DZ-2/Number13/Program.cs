// // С использованием метода
// Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
// Console.Write("Введите число: ");
// string str = Console.ReadLine();
// if (int.Parse (str)/100 == 0)
// {
//     Console.WriteLine("В этом числе нет третьей цифры.");
// }
// else
// {
//     Console.WriteLine($"Третья цифра {FindNumberThree(str, 3)}");
// }


// int FindNumberThree(string str, int index)
// {
//     int number = Convert.ToInt32(new string( str[index - 1], 1));
//     return number;
// }



// Минималистский вариант
// string str = Console.ReadLine();
// if (str.Length < 3) Console.WriteLine("В этом числе нет третьей цифры.");
// else Console.WriteLine($"Третья цифра {Convert.ToInt32(new string( str[2], 1))}");




//Решение от Сергея Джумаева
//
// Статический импорт пространства имён System.Console 
// (чтобы можно было просто писать WriteLine/ReadLine)
using static System.Console;
Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(ReadLine()));
if (number > 99) {WriteLine(number / (int)Math.Pow(10, GetDigitCounts(number) - 3) % 10);}
else {WriteLine("Число состоит менее, чем из 3-х цифр");}

int GetDigitCounts(int number) {
    int digitCounts = 1; int N = number / 10;
    while(N > 0) {N = N / 10; digitCounts++;}
    return digitCounts;}
