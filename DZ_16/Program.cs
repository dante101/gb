// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 10;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 99;

void SumNegativeNumber (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count+=array[i];
        }
    }
    Console.WriteLine(count);
}

int[] myArray = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", myArray));
SumNegativeNumber(myArray);

