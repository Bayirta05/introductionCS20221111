//84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
//Вычислить сумму цифр введенного числа

int SumDigit(int n)
 {
    if (n==0) return 0;
    else
    return SumDigit(n/10)+n%10;
}

string s=Console.ReadLine();
int n=Convert.ToInt32(s);
System.Console.WriteLine(SumDigit(n));