//72. Показать натуральные числа от M до N, N и M заданы

void Num(int M,int N)
{
    if (N>=M)
    {
        System.Console.Write($"{M, 3}");
        Num(M+1,N);
    }    
}


Num(4,8);