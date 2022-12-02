//51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] ArrayNum(int Number)
{
    int[] a=new int[Number];
    for(int i=0;i<a.Length;i++)
        a[i]=Convert.ToInt32(Console.ReadLine());
    return a;
}

int CountNum(int[] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>0) count+=1;
    return count;
}

int N=Convert.ToInt32(Console.ReadLine());
int[] a=ArrayNum(N);
System.Console.WriteLine();
System.Console.WriteLine(CountNum(a));