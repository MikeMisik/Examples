// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Задаем рандомную матрицу
int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)

{
    int[,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder);
        }
    }
    return matrix;
}

// Вывод матрицы
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

void fromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i,0];
            int temp;
            if(matrix[i,j] > max)
            {
            temp = matrix[0,0];
            max = matrix[i,j];
            matrix[i,j] = temp;
            }
            // else if(matrix[i,j] <= max) j++;


        }

    }
}

int m = 5;
int n = 5;
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
fromMaxToMin(myMatrix);
Console.WriteLine("____________");
PrintMatrix(myMatrix);
