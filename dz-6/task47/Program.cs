// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void GetRandomMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 10;
            Console.Write("{0,6:f1}", matrix[i, j]);
        }
        Console.WriteLine();

    }

}


Console.Write("Введите кол-во строк: ");
int rowses = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во стобцов: ");
int columses = Convert.ToInt32(Console.ReadLine());

GetRandomMatrix(rowses, columses);