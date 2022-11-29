// Рассчитать среднюю температуру за неделю

/*int t1,t2,t3,t4,t5,t6,t7;
double s;
t1=Convert.ToInt32(Console.ReadLine());
t2=Convert.ToInt32(Console.ReadLine());
t3=Convert.ToInt32(Console.ReadLine());
t4=Convert.ToInt32(Console.ReadLine());
t5=Convert.ToInt32(Console.ReadLine());
t6=Convert.ToInt32(Console.ReadLine());
t7=Convert.ToInt32(Console.ReadLine());
s=(t1+t2+t3+t4+t5+t6+t7)/7;
System.Console.WriteLine(s);
*/
// массивы - это объекты
int N=7;
int[] t; // не присвоенное (null)
t=new int[N];// создаем массивб т.е. в t помещаем адрес массива
double s=0;
// заполнить массив
for(int i=0;i<t.Length;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
// обработать массив
for(int i=0;i<t.Length;i++)
    s=s+t[i];
//вывод результата
System.Console.WriteLine(s/t.Length);