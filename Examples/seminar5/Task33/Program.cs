// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsElementInArray(int[] array, int findNumber)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumber)
        {
            result = true;
            break;
        }
    }    
    return result;
    
}

int lengthOfArray = ReadNumber("Введите длину массива ");
int leftBorder = ReadNumber("Введите левую границу диапазона ");
int rightBorder = ReadNumber("Введите правую границу диапазона ");
int Finding = ReadNumber("Какое число искать в массиве?");
int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
bool res = IsElementInArray(myArray, Finding);
Console.WriteLine(res);
