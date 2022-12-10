//77. Написать программу показывающую первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
//Первые два элемента последовательности 0 и 1 

void Fib(int N,int i)
{
    if (i<=N)
    {
        //System.Console.WriteLine(i);
        Loop(N,i+1);
    }    
}

int N=Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
a[0]=0;
a[1]=1;
for(int i=2;i<N;i++)
    a[i]=a[i-1]+a[i-2];
for(int i=0;i<N;i++)
    System.Console.Write($"{a[i]} ");