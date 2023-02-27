// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int[] reverseArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }    
    return array;
}

int lengthOfArray = ReadNumber("Введите длину массива ");
int leftBorder = ReadNumber("Введите левую границу диапазона ");
int rightBorder = ReadNumber("Введите правую границу диапазона ");

int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"Первоначальный массив: [{string.Join(", ", myArray)}]");
int[] ReverseMyArray = reverseArray(myArray);
Console.WriteLine($"Инвертированный массив: [{string.Join(", ", myArray)}]");