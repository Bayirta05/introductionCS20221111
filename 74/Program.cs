//74. Найти сумму цифр числа

int SumDigit(int N)
 {
    if (N==0) return 0;
    else
    return SumDigit(N/10)+N%10;
}
int N=315;
System.Console.WriteLine($"Сумма цифр числа {N} равна:");
System.Console.WriteLine(SumDigit(N));