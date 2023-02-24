/*  Задача 25: Напишите цикл, который принимает 
 на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ReadNumber1 (string msgToUser)
{
    Console.WriteLine(msgToUser);
    return Convert.ToInt32(Console.ReadLine()); 
}

int ReadNumber2 (string msgToUser)
{
    Console.WriteLine(msgToUser);
    return Convert.ToInt32(Console.ReadLine()); 
}

int Power (int num1, int exp)
{
    int powerNum = 1;
    for (int i = 0; i < exp; i++)
    {
        powerNum *= num1; // powerNum = powerNum * num1
    }
    return powerNum;
}

int numberA = ReadNumber1("Введите число A ");
int numberB = ReadNumber2("Введите число B ");
int result = Power(numberA, numberB);
Console.WriteLine(result);



