﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3->A(m, n) = 9

int ankF(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return ankF(n - 1, 1);
    if (n > 0 && m > 0) return ankF(n - 1, ankF(n, m - 1));
    return ankF(n, m);
}

int[] userArray(string[] array, Func<string, int> f)
{
    int[] array_01 = new int[array.Length];
    for (int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = f($"Введите {array[idx]}: ");
        array_01[idx] = nextEl;
    }
    return array_01;
}

int nextEl(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while (resVal == false || num < 0)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if (resVal == false || num < 0)
        {
            Console.WriteLine("Ошибка! Попробуйте еще раз.");
        }
    }
    return num;
}

while (true)
{
    Console.Write("\n");
    Console.WriteLine("\nНажмите 's' и Enter для ввода или 'q' для выхода из программы: ");
    string usrQuest = Console.ReadLine();
    if (usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Подсчет окончен!");
        break;
    }
    else if (usrQuest.ToLower() == "s")
    {
        string[] usArrayStr = { "m", "n" };
        int[] usArrayInt = userArray(usArrayStr, nextEl);
        int result = ankF(usArrayInt[0], usArrayInt[1]);
        Console.WriteLine($"\nРезультат вычисления: {result}");
    }
}
