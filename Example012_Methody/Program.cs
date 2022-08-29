// //Вид1
// void Method1()
// {
//     Console .WriteLine ("Автор...");
// }
// Method1 ();

// //Вид2

// void Method2(string msg)
// {
//     Console .WriteLine (msg);
// }
// Method2 ("Текст сообщения");

// Method2 (msg:"Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count )
//     {
//         Console .WriteLine (msg);
//         i++;
//     }

// }
// Method21 ("Текст", 4);
// Method21 (count: 4, msg: "Новый Текст");


// //Вид3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3 ();
// Console .WriteLine (year);

// //Вид4

// string  Method4(int count, string text)
// {
//     int i=0;
//     string result=String .Empty ;
//     while(i<count )
//     {
//         result =result+text;
//         i++;
//     }
//     return result ;
// }
// string  res=Method4 (10, "As");
// Console .WriteLine (res);

// //Вид4

// string  Method4(int count, string text)
// {
//     string result=String .Empty ;
//     for(int i=0; i<count; i++)
//     {
//         result =result+text;
//     }
//     return result ;
// }
// string  res=Method4 (10, "As");
// Console .WriteLine (res);

// for(int i=2;i<=10;i++)
// {
//     for(int j=2;j<=10;j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// string text = "Русская абракадабра";

// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue)
//         {
//             result = result + $"{NewValue}";
//         }
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// Console.WriteLine(text);
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


int[] arr={1,4,6,0,7,4,3,9,7,6};
PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);

void PrintArray(int[] array)
{
    int count=array.Length;
    for(int i=0;i<count ;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] arrey)
// сортирует целый массив от минимального к максимальному
{
    int count=arr.Length;
    for(int i =0;i<count-1;i++)
    {
        int minPosition=i;
        for(int j=i+1;j<count ;j++)
        {
            if(arr[minPosition]>arr[j]) {minPosition=j;}
        }
        int temp=arr[minPosition ];
        arr[minPosition ]=arr[i];
        arr[i]=temp ;
    }
}

void SelectionSortMax(int[] arrey)
// сортирует целый массив от максимального к минимальному
{
    int count=arr.Length;
    for(int i =0;i<count-1;i++)
    {
        int maxPosition=i;
        for(int j=i+1;j<count ;j++)
        {
            if(arr[maxPosition]<arr[j]) {maxPosition=j;}
        }
        int temp=arr[maxPosition ];
        arr[maxPosition ]=arr[i];
        arr[i]=temp ;
    }
}
