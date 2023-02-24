/* Задача 27: Напишите программу, которая 
 принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int ReadNumber (string msgToUser)
{
    Console.WriteLine(msgToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int DigitSum (int number)
{
    int Sum = 0;
    while(number > 0)
    {
        Sum += number % 10; //Sum = Sum + number % 10
        number /= 10;
    }
    return Sum;
}
int userNumber = ReadNumber("Введите число");
int result = DigitSum(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {result}");

