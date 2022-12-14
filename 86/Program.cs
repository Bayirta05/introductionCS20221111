//86. Подсчитать сколько раз определенный символ
// (например 'a') встречается в строке.

string s=Console.ReadLine();
char c='b';
int k=0;
/*for(int i=0;i<s.Length;i++)
    if (s[i]==c) k++;
*/
foreach(char i in s)
    if (c==i) k++;
System.Console.WriteLine(k);  