// Задача 38: Задайте массив натуральных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int Max(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Максимальное число массива :{max}");
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Минимальное число  массива :{min}");
    return min;
}


int[] myArray = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine($"Сумма максимального и минимального значений массива равна:{Max(myArray)+ Min(myArray)}");