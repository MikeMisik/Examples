// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber (string msgToUser)
{
    Console.WriteLine(msgToUser);
    return Convert.ToInt32(Console.ReadLine());
    
}

int DigitCount (int number)
{
    int count = 0;
    for (count = 0; number != 0; count++)
    {
        number /= 10; //number = number / 10:
    }
    return count;
}
int userNumber = ReadNumber("Введите число");
int result = DigitCount(userNumber);
Console.WriteLine(result);
