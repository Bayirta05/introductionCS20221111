//56. Написать программу копирования массива

int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    //Заполнили массив
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(-9,9);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}

void NewArr(ref int a,ref int b)
{
    b=a;
}

void CopyArr(int[] a)
{
    int[] copy=new int[a.Length];
    for(int i=0;i<a.Length;i++)
        NewArr(ref a[i],ref copy[i]);
}

void PrintCopy(int[] copy)
{
    for(int i=0;i<copy.Length;i++)
        System.Console.Write($"{copy[i],5}");
}

int[] a=RandomIntArray(3,-5,5);
PrintArray(a);
CopyArr(a);
System.Console.WriteLine();
PrintCopy(a);