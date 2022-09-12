// Задача 60
// Программа генерирует трёхмерный массив из неповторяющихся двузначных чисел.
// И построчно выводит его, добавляя индексы каждого элемента.
using static System.Console;
int quantity=3;
int[] size = new int[quantity];
int counElements=91;
while(counElements>90)
{
    string text="Введите через пробел размеры трёхмерного массива: ";
    size = InputCoord(quantity,text);
    counElements=size[0]*size[1]*size[2];
    if(counElements>90)
    {
        WriteLine("Слишком большие размеры - не хватит уникальных двузначных чисел (max=90)");
    }
}
int[,,] array3D=Fill3DIntArrayNonrepeating(size,10,99);
WriteLine($"Массив [{size[0]}, {size[1]}, {size[2]}]:");
Print3DIntArray(array3D);


int[,,] Fill3DIntArrayNonrepeating(int[] size,int min,int max)
// Заполнение трёхмерного массива уникальными целыми числами.
{
    Random random = new Random();
    int[,,] arr3D=new int[size[0],size[1],size[2]];
    int length=size[0]*size[1]*size[2];
    int[] uniq=new int[length];
    int count=0;
    bool unique=false;
    for(int i=0;i<arr3D.GetLength(0);i++)
    {
        for(int j=0;j<arr3D.GetLength(1);j++)
        {
            for(int k=0;k<arr3D.GetLength(2);k++)
            {
                while(!unique)
                {
                    unique=true;
                    arr3D[i, j,k] = random.Next(min,max+1);
                    for(int l=0;l<count;l++)
                    { 
                        if(arr3D[i, j,k]==uniq[l])
                        {
                            unique=false;
                            l=count;
                        }
                    }
                    if(unique)
                    {
                        uniq[count]=arr3D[i, j,k];
                        count++;
                    }
                }
                unique=false;
            }
        }
    }
    return arr3D;
}

int[] InputCoord(int quantity,string text)
// Ввод данных строкой с разделилением через пробел.
{
    bool isNumber = false;
    bool[] isCoord=new bool[quantity];
    int[] coord=new int[quantity];
    while (!isNumber)
    {
        WriteLine();
        Write(text);
        string? posit=ReadLine();
        if(posit==null) {posit="";}  //чтоб не ругался
        string[] position = posit.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if(position.Length<quantity) {WriteLine($"Надо ввести {quantity} значения");}
        else
        {
            bool isAll=true;
            for(int i=0;i<quantity;i++)
            {
                isCoord[i] = int.TryParse(position[i], out coord[i]);
                if(!isCoord[i]) {isAll=false;}
            }
            if(!isAll) { WriteLine("Позиция задана не верно, вероятно, не все числа"); }
            else
            {
                for(int i=0;i<quantity;i++) {if(coord[i]<0) {isAll=false;}}
                if(!isAll) { WriteLine("Позиции элементов не могут быть отрицательными"); }
                else {{isNumber=true;}}
            }
        }
    }
    return coord;
}

void Print3DIntArray(int[,,] arr)
// Вывод на экран трёхмерного целочмсленного массива с указанием индекса элемента.
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Write($"{arr[i, j,k]}({i},{j},{k})  ");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}
