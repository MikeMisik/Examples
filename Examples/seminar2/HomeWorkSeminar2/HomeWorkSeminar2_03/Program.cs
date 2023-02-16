// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня ");
int daynumber = Convert.ToInt32(Console.ReadLine());

if (daynumber < 6)
{
    Console.WriteLine("Этот день недели не является выходным ");
}
else if (daynumber == 6 || daynumber == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else {
    Console.WriteLine("Нет такого дня недели");
}
