// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SumImatrix(int[,] matrix)
{
    int sum = 0;
    int[] matrixSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
            matrixSum[i] = sum;
        }
        sum = 0;
    }
    int minMatrixSum = matrixSum[0];
    int indexMinMatrix = 1;
    for (int i = 0; i < matrixSum.Length; i++)
    {
        if(matrixSum[i] < minMatrixSum)
        {
            minMatrixSum = matrixSum[i];
            indexMinMatrix = i + 1;
        } 
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + indexMinMatrix);
}





const int ROWS = 5;
const int COLUMNS = 4;
const int LEFT_RaNGE = 1;
const int RIGHT_RaNGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RaNGE, RIGHT_RaNGE);
PrintMatrix(array);
SumImatrix(array);