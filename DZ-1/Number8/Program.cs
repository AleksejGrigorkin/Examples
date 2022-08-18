Console.WriteLine("Программа на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int j=0;
if(N<0) Console.Write("В заданном диапазоне нет положительных чётных чисел");
else if (N<2) Console.Write("В заданном диапазоне нет чётных чисел");
while (i <= N)
{
    int m=i%2;
    if(m==0)
    {
        if(j>0) Console.Write(", ");
        Console.Write(i);
        j=1;      
    }
    i++;
}
Console.WriteLine("");
