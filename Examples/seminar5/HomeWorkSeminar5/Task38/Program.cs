//  Задача 38: Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Задаём рандомный массив с помощью метода
int[] GetRandomArray(int length, int leftRange, int rightRange) 
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}
// Метод поиска максимального и минимального значений массива
(int, int) findMaxAndMinElement(int[] array)  
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
        if(array[i] < min) min = array[i];
    }
    return (max, min);
}

int lengthOfArray = 5;
int leftBorder = 10;
int rightBorder = 100;

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine(($"[{string.Join(", ", myArray)}]"));
(int maxElement, int minElement) = findMaxAndMinElement(myArray);
Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {maxElement - minElement}");