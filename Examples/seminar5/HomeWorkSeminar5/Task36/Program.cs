//  Задача 36: Задайте одномерный массив, 
//  заполненный случайными числами. Найдите сумму элементов, 
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

int sumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int lengthOfArray = 10;
int leftBorder = 1;
int rightBorder = 5;

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine(($"[{string.Join(", ", myArray)}]"));
int sumOdds = sumOddPositions(myArray);
Console.WriteLine($"Сумма всех элементов, стоящих на нечетных позициях равна: {sumOdds}");