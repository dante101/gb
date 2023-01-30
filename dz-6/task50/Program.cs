// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


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

void Newmatrix(int[,] matrix)
{
    Console.WriteLine("Введите номер строки");
    int numi = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int numj = int.Parse(Console.ReadLine());
    if (numi <= matrix.GetLength(0) && numj <= matrix.GetLength(1))
    {
        Console.WriteLine($"Ваше число: {matrix[numi - 1, numj - 1]}");
    }
    else Console.WriteLine("Такого числа нет ");
}

Console.WriteLine();

const int ROWS = 5;
const int COLUMNS = 4;


int[,] array = GetRandomMatrix(ROWS, COLUMNS);
Newmatrix(array);