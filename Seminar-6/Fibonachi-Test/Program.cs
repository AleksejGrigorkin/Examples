// See https://aka.ms/new-console-template for more information
//Демонстрация решения
//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] array = new int[] {1,2,3,4,5}; 
PrintArray(array);
int [] reverseArray = ReverseArray(array);
Console.WriteLine();
PrintArray(reverseArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int[] ReverseArray(int[] array)
{
    /* int tmp;
    tmp = array[1];
    array[1] = array[3];
    array[3] = tmp;
    */

    int[] reverseArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - 1 - i];
    }

    return reverseArray;
}

int k = 0;
    Recursive();
    Console.WriteLine("Я поймал!!!!");


void Recursive()
{
    Console.WriteLine(k);
    k++;
    Recursive();
}

double FibonacciBad(int n)
{
    if(n == 1 || n == 2) return 1;
    else return FibonacciBad(n-1) + FibonacciBad(n-2);
}

double FibonacciR(double[] f, int n)
{
    if (n == 1 || n == 2)
    {
        return f[n - 1] = 1;
    }

    if (f[n - 2] != 0)
    {
        if (f[n - 1] != 0)
        {
            return f[n - 1] = f[n - 2] + f[n - 3];
        }

        return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
    }

    return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
}

double FibonacciGood(int n)
{
    
    double[] f = new double[n];
    return FibonacciR(f, n);
}


int countTests = 40;


DateTime saveTime;

Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"f({i}) = {fibonacci2}");
    int temporary = fibonacci2;
    fibonacci2 += fibonacci1;
    fibonacci1 = temporary; 
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 0; i <= countTests; i++)
{

    Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

    Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");