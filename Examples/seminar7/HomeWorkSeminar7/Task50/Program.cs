//  Задача 50: Напишите программу, которая 
//  на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
    
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{

    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementInMatrix(int[,] matrix)
{
    int rowsIndex = ReadNumber("Введите индекс строки");
    int columnsIndex = ReadNumber("Введите индекс столбца");
    if(rowsIndex >= matrix.GetLength(0) | columnsIndex >= matrix.GetLength(1))
        Console.WriteLine("Такого элемента не существует в матрице, перезапустите программу");
    else
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(rowsIndex == i && columnsIndex == j)
                Console.WriteLine($"Элемент с индексом {rowsIndex}, {columnsIndex} -> {matrix[i,j]}"); 
            }        
        }
}
int m = 3;
int n = 4;
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
FindElementInMatrix(myMatrix);
