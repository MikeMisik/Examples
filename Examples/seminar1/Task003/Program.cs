// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня ");
int daynumber = Convert.ToInt32(Console.ReadLine());
 
if (daynumber == 1)
{
    Console.WriteLine("понедельник");
}
else if (daynumber == 2)
{
    Console.WriteLine("вторник");
}
else if (daynumber == 3)
{
    Console.WriteLine("среда");
}
else if (daynumber == 4)
{
    Console.WriteLine("четверг");
}
else if (daynumber == 5)
{
    Console.WriteLine("пятница, БУХАЕМ!!!");
}
else if (daynumber == 6)
{
    Console.WriteLine("суббота");
}
else if (daynumber == 7)
{
    Console.WriteLine("воскресенье");
}
else 
{
    Console.WriteLine("нет такого дня недели");
}