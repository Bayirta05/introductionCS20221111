//70. Показать натуральные числа от 1 до N, N задано

void Num(int N,int i)
{
    if (i<=N)
    {
        System.Console.Write($"{i, 3} ");
        Num(N,i+1);
    }    
}

Num(5,1);