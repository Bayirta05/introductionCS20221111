//12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());
int a=N%10;
int b=N/10;
if (a>b)
{
    System.Console.WriteLine($"{a} наибльшая цифра числа {N}");
}
else
{
    System.Console.WriteLine($"{b} наибольшая цифра числа {N}");
}