//  Задача 41: Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int ReadNumber (string msgToUser)
{
    Console.WriteLine(msgToUser);
    return Convert.ToInt32(Console.ReadLine());
     
}

int[] GetUserArray(int length) 
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber("Введите число ");
    }
    return array;
}

int CountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int[] myArray = GetUserArray(6);
Console.WriteLine(($"[{string.Join(", ", myArray)}]"));
int positiveNumbers = CountOfPositiveNumbers(myArray);
Console.WriteLine($"Количество чисел больше нуля равно: {positiveNumbers}");
