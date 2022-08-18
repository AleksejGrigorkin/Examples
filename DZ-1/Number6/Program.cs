Console.WriteLine("Программа на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number%2;
if(n==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
