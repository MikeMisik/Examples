// Напишите программу, которая на вход 
// принимает число (А) и выдает сумму чисел от 1 до (А)
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadNumber (string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

int number = ReadNumber("Введите число А ");
int result = SumToA(number);
Console.WriteLine(result);
