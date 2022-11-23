//26. Найти сумму чисел от 1 до А
int Summa(int Number)
{
    int result=0;
    for(int i=1;i<=Number;i++)
    {
        result+=i;
    }
    return result;
}
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summa(A));