//37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] RandomIntArray(int size=8)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(100,1000);
    return a;
}

int CountEven(int[] a)
{
    int s=0;
    foreach(int el in a)
        if (el%2==0) s=s+1;
    return s;
}

int CountOdd(int[] a)
{
    int s=0;
    foreach(int el in a)
        if (el%2!=0) s=s+1;
    return s;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray();
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных равно {CountEven(a)}");
System.Console.WriteLine($"Количество нечетных равно {CountOdd(a)}");