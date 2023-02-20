// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= n)
{
    double n2 = Math.Pow(count, 2);
    Console.WriteLine(n2);
    count ++;
}




