﻿ 
// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10000 || N > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число - перезапустите программу ");
}
else
{
    int a = N % 10;
    int b = (N / 10) % 10;
    int d = (N / 1000) % 10;
    int e = (N / 10000) % 10;
    if (a == e && b == d)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
    
}


