using static System.Console;
int a=int.Parse(ReadLine());
int b=int.Parse(ReadLine());
int c=int.Parse(ReadLine());
if(a>0&&b>0&&c>0&&a+b>c&&a+c>b&&b+c>a) {WriteLine("Треугольник");}
else {WriteLine("Неверные параметры");}
