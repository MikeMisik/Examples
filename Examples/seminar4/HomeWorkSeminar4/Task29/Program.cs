﻿/* Задача 29: Напишите программу, которая 
 задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Напишите сколько элементов хотите видеть в массиве ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", " , array)}]");

