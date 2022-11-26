// С клавиатуры вводится число. Определить день недели

int day=1;
if (day==1) System.Console.WriteLine("Понедельник");

switch(day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    default:
        System.Console.WriteLine("Неправильный ввод");
        break;
}

metka1:

goto metka1; //оператор безусловного перехода
//GOTO -нельзя использовать

void Test()
{
    metka2:
        System.Console.WriteLine();
}