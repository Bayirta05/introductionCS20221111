//71. Показать натуральные числа от N до 1, N задано

void Num(int N,int i)
{
    if (N>=i)
    {
        System.Console.Write($"{N, 3}");
        Num(N-1,i);
    }    
}


Num(10,1);