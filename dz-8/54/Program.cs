// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinMaxNatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] <= matrix[i, k]) continue;
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }

    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
}



    const int ROWS = 5;
    const int COLUMNS = 4;
    const int LEFT_RaNGE = -9;
    const int RIGHT_RaNGE = 10;

    int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RaNGE, RIGHT_RaNGE);
    PrintMatrix(array);
    MinMaxNatrix(array);

