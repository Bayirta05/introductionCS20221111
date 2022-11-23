//27. Возведите число А в натуральную степень B используя цикл
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int result=a;
for(int i=1;i<b;i++)
{
    result*=a;
}
System.Console.WriteLine(result);