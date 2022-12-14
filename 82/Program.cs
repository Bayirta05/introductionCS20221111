//82. C клавиатуры вводится строка разделенная точкой.
// Подсчитать количество символов до точки

string s=Console.ReadLine();
int count=0;
for(int i=0;i<s.IndexOf(".");i++)
    count+=1;
System.Console.WriteLine(count);