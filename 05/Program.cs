//5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
System.Console.WriteLine("Введите число a:");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c:");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
System.Console.WriteLine($"{max} - максимальное число");