//80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

void TableASCII()
{
    for (int i=32;i<=122;i++)
    Console.WriteLine(i.ToString() +" - "+ (char)i);
}

TableASCII();