//22. Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число:");
int n=Convert.ToInt32(Console.ReadLine());
int d1=n%10;
int d2=(n/10)%10;
int d3=(n/1000)%10;
int d4=(n/10000)%10;
if (d1==d4 && d2==d3) System.Console.WriteLine("YES"); 
    else
        System.Console.WriteLine("NO");