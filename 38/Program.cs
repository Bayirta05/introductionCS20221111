//38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=123,int min=0,int max=500)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int CountNum(int[] a)
{
    int s=0;
    foreach(int el in a)
        if (el>10 && el<99) s=s+1;
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
System.Console.WriteLine($"Количество чисел равно {CountNum(a)}");