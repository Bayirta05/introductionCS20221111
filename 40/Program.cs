//32. Задать массив из 8 целых элементов и вывести их на экран

int[] RandomIntArray(int size=8)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(0,10);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] mas=RandomIntArray();
Print(mas);