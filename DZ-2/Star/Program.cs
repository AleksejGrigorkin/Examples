// // Без использования метода
// Console.WriteLine("Программа принимает на вход количество (до 10) трёхзначных чисел. Генерирует их");
// Console.WriteLine("Находит их среднее арифметическое, проверяет больше ли его последняя цифра,");
// Console.WriteLine("чем первая цифра минимального числа.");
// Console.Write("Введите количество (до 10) трёхзначных чисел: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int minnumber = 1000;
// Random random = new Random();
// int[] number = new int[count];
// for (int i=0; i < count; i++)
// {
//     number[i] = random.Next(100, 1000); // заполняем массив случайными трёхзначными числами
//     Console.WriteLine(number[i]);
//     if (minnumber > number[i])
//     {
//         minnumber = number[i]; // ищем минимальное число
//     }
//     sum = sum + number[i]; // считаем сумму чисел
// }
// int firstnumber = minnumber / 100;
// int lastnumber = sum % count;
// // предполагается, что среднее арифметическое - double
// double sr = sum;         // для контроля работы
// sr = sr / count;         // для контроля работы
// Console.WriteLine(sr);
// if (lastnumber == 0)
// {
//     lastnumber = sum / count % 10;
// }
// else if(count ==7)
// {
//     Console.WriteLine("Задача не имеет решения.");
//     goto finish;
// }
// else if (lastnumber * 1000 / count % 10 == 0)
// {
//     if (lastnumber * 100 / count % 10 == 0)
//     {
//         lastnumber = lastnumber * 10 / count % 10;
//     }
//     else
//     {
//         lastnumber = lastnumber * 100 / count % 10;
//     }
// }
// else
// {
//     lastnumber = lastnumber * 1000 / count % 10;
// }
// Console.WriteLine(firstnumber);
// Console.WriteLine(lastnumber);
// if (firstnumber > lastnumber)
// {
//     Console.WriteLine("<<Первая>> цифра больше <<последней>>.");
// }
// else if (firstnumber < lastnumber)
// {
//     Console.WriteLine("<<Первая>> цифра меньше <<последней>>.");
// }
// else
// {
//     Console.WriteLine("<<Первая>> и <<последняя>> равны.");
// }
// finish:
// Console.WriteLine("Работа программы завершена");



// Минималистский вариант
int count = Convert.ToInt32(Console.ReadLine());  // Введите количество (до 10) трёхзначных чисел
int sum = 0; int minnumber = 1000;                // Программа принимает на вход количество (до 10) трёхзначных чисел.
Random random = new Random();                     // Генерирует их. Находит их среднее арифметическое, проверяет 
int[] number = new int[count];                    // больше ли его последняя цифра,чем первая цифра минимального числа.
for (int i = 0; i < count; i++)
{   number[i] = random.Next(100, 1000);               // заполняем массив случайными трёхзначными числами
    if (minnumber > number[i]) minnumber = number[i]; // ищем минимальное число
    sum = sum + number[i];}                           // считаем сумму чисел
int firstnumber = minnumber / 100; int lastnumber = sum % count;
if (lastnumber == 0) lastnumber = sum / count % 10;
else if (count == 7) { Console.WriteLine("Задача не имеет решения."); goto finish; }
else if (lastnumber * 1000 / count % 10 == 0)
{   if (lastnumber * 100 / count % 10 == 0) lastnumber = lastnumber * 10 / count % 10;
    else lastnumber = lastnumber * 100 / count % 10;}
else lastnumber = lastnumber * 1000 / count % 10;
if (firstnumber > lastnumber) Console.WriteLine("<<Первая>> цифра больше <<последней>>.");
else if (firstnumber < lastnumber) Console.WriteLine("<<Первая>> цифра меньше <<последней>>.");
else Console.WriteLine("<<Первая>> и <<последняя>> равны.");
finish: Console.WriteLine("Работа программы завершена");
