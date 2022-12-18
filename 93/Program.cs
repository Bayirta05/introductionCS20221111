/*
93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int[,] RandomFirstArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] RandomSecondArray(int n,int m,int min=0,int max=10)
{
    int[,] b=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                b[i,j]=random.Next(min,max+1);
    return b;
}

int[,] Result2DArray(int[,] a, int[,] b, int n, int m)
{
    int[,] c=new int[n,m];
    for(int i=0;i<c.GetLength(0);i++)    
        for(int j=0;j<c.GetLength(1);j++)
            c[i,j]=a[i,j]*b[i,j];
    return c;
}

void PrintResultArray(int[,] c)
{
    for(int i=0;i<c.GetLength(0);i++)
        {
        for(int j=0;j<c.GetLength(1);j++)
        System.Console.Write($"{c[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] a=RandomFirstArray(5,5);
int[,] b=RandomSecondArray(5,5);
int[,] c=Result2DArray(a,b,5,5);
Print2DArray(a);
System.Console.WriteLine();
Print2DArray(b);
System.Console.WriteLine();
PrintResultArray(c);
