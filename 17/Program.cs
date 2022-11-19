//17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int d=Convert.ToInt32(Console.ReadLine());
if (d==6 || d==7) System.Console.WriteLine("Выходной"); else System.Console.WriteLine("Работаем");