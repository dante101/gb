// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

void CountNumber (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]>= 10 && array[i] <= 99)
        {
            count+=1;
        }
    }
    Console.WriteLine(count);
}

int[] myArray = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", myArray));
CountNumber(myArray);