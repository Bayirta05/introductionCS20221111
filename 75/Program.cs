//75. Написать программу вычисления функции Аккермана - 5*

int Akker(int m,int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Akker(m-1,1);
    if (m>0 && n>0) return Akker(m-1, Akker(m,n-1));
    return Akker(m,n);
}

System.Console.WriteLine(Akker(0,2));