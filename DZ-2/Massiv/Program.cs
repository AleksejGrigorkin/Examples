using static System.Console;
Write("Введите число: ");
string number = ReadLine();
char[] numberArr = number.ToArray<char>();
int length = numberArr.Length;
Write(numberArr[0]);
if (length > 1) { for (int i = 1; i < length; i++) { Write(", " + numberArr[i]); } }
WriteLine("");
