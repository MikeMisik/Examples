﻿/* Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/ 

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

(int, int) SumPositiveAndNegativeElements(int[] array)
{
    int sumPositive = 0; //сумма положительных чисел
    int sumNegative = 0; //сумма отрицательных чисел

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) // если наш элемент положительный
        {
            sumPositive = sumPositive + array[i];
            //sumPositive += array[i];
        }
        else if (array[i] < 0)
        {
            sumNegative = sumNegative + array[i];
        }
    }

    return (sumPositive, sumNegative);
}

int lengthOfArray = ReadNumber("Введите длину массива ");
int leftBorder = ReadNumber("Введите левую границу диапазона ");
int rightBorder = ReadNumber("Введите правую границу диапазона ");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

Console.WriteLine($"[{string.Join(", ", myArray)}]");
(int sumP, int sumN) = SumPositiveAndNegativeElements(myArray);
Console.WriteLine($"Сумма положительных элементов = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов = {sumN}");

