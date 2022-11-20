//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double x,y;
x=Convert.ToDouble(Console.ReadLine());
y=Convert.ToDouble(Console.ReadLine());
if (x>0 && y>0) System.Console.WriteLine("1");
    else
        if (x<0 && y>0) System.Console.WriteLine("2");
            else
                if (x<0 && y<0) System.Console.WriteLine("3");
                else
                    System.Console.WriteLine("4");