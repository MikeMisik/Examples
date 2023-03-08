// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//Метод вычисления среднего арифметического каждого столбца
void AverageInColumns(int[,] matrix) 
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {     
            sum += matrix[i, j];
        }
        Console.Write(sum / matrix.GetLength(1) + " ");
    }   
}


int m = 5;
int n = 5;
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
AverageInColumns(myMatrix);
