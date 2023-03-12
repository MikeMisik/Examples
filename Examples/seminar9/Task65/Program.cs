// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 1;
int n = 5; 

void Print1ToN(int end, int start)
{
    if (end < start) return;
    Print1ToN(end - 1, start);
    Console.Write($"{end} ");
}

Print1ToN(n, m);

