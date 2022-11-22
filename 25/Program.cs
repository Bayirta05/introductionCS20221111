//25. Вывести на экран кубы чисел от 1 до N

int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=N)
{
    int c=(int)Math.Pow(i,3);
    System.Console.WriteLine($"Куб числа {i} равен {c}");
    i++;
}
