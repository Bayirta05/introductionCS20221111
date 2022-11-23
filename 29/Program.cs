//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
int SumDigits(int Number)
{
    int result=0;
    while(Number>0)
    {
        result+=Number%10;
        Number=Number/10;
    }
    return result;
}

System.Console.WriteLine("Введите число:");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа {n} равна {SumDigits(n)}");