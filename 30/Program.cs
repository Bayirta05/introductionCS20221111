//30. Написать программу вычисления произведения чисел от 1 до N
int Multi(int Number)
{
    int a=1;
    for(int i=1;i<=Number;i++)
    {
        a*=i;
    }
    return a;
}
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Multi(n));