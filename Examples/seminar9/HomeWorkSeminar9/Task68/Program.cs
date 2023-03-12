// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

uint m = 2;
uint n = 3;
Console.WriteLine(AckFuncion(m, n));

uint AckFuncion(uint m, uint n)
{
    if (m == 0) 
    return n + 1;

    else if ((m > 0) && (n == 0))
    return AckFuncion(m - 1, 1);

    else // (m > 0) && (n > 0)
    return AckFuncion(m - 1, AckFuncion(m, n - 1));
}
