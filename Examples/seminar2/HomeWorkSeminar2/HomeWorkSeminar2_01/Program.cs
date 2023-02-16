
// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int min = 100;
int max = 999;

if (number < min || number > max)
{
    Console.WriteLine("Введённое число не является трёхзначным ");
}
else 
{
    int digit2 = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра введённого числа: {digit2}");
}

