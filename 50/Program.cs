//50. Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a,int b, int c)
{
    return a+b>c && b+c>a && a+c>b;
}
int a=4,b=5,c=8;
if (CheckTriangle(a,b,c)) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");
