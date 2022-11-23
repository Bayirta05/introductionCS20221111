//24. Вывести на экран таблицу квадратов чисел от 1 до N
int N=Convert.ToInt32(Console.ReadLine());
int square=0;
for(int i=1;i<=N;i++)
{
    square=i*i;
    System.Console.WriteLine($"{i} * {i} = {square}");
}
