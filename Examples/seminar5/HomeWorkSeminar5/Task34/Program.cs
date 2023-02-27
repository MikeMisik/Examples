//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

int countEvenNumbers(int[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int lengthOfArray = 8;
int leftBorder = 100;
int rightBorder = 1000;

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine(($"[{string.Join(", ", myArray)}]"));
int countEvenNum = countEvenNumbers(myArray);
Console.WriteLine($"Количество четных элементов массива: {countEvenNum}");