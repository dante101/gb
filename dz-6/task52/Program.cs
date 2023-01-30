// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return matrix;
}

const int ROWS = 5;
const int COLUMNS = 4;


int[,] array = GetRandomMatrix(ROWS, COLUMNS);
double[] result = new double[array.GetLength(1)];
double sum = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j, i];
        result[i] = Math.Round(sum / (array.GetLength(0)), 1);
    }
    sum = 0;
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine(string.Join("; ", result));

