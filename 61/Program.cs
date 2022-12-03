﻿//61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArray(int m,int n)
{
    double[,] a=new double[m,n];
    Random random=new Random();
    for(int i=0;i<m;i++)
         for(int j=0;j<n;j++)
                a[i,j]=random.NextDouble()*100;
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write("{0,6:F2}", a[i,j], 20);
           System.Console.WriteLine();
        }
}

double[,] a=Random2DArray(5,5);
Print2DArray(a);