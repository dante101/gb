// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numSum(int M, int N, int sum = 0)
{
    if(M > N) return sum;
    sum += M;
    return numSum(M + 1, N, sum);    
}

int[] userArray(string[] array, Func<string, int> f)
{
    int[] array_01 = new int[array.Length];
    for(int idx = 0; idx < array.Length; idx++)
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
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = Int32.TryParse(elem, out num);
        if(resVal == false)
        {
            Console.WriteLine("Ошибка! Попробуйте еще раз.");
        }
    }
    return num;
}

while(true)
{
    Console.Write("\n");
    Console.WriteLine("\nНажмите 's' и Enter для ввода или 'q' для выхода из программы: ");
    string usrQuest = Console.ReadLine();
    if(usrQuest.ToLower() == "q")
    {
        Console.WriteLine("Подсчет окончен!");
        break;
    }
    else if(usrQuest.ToLower() == "s")
    {
        string[] usArrayStr = {"M", "N"};
        int[] usArrayInt = userArray(usArrayStr, nextEl);
        if(usArrayInt[0] <= usArrayInt[1])
        {
            int resSum = numSum(usArrayInt[0], usArrayInt[1]);
            Console.WriteLine($"\nРезультат суммы натуральных элементов в промежутке от M до N: {resSum}");
        } 
        else
        {
            int resSum = numSum(usArrayInt[1], usArrayInt[0]);
            Console.WriteLine($"\nРезультат суммы натуральных элементов в промежутке от M до N: {resSum}");
        }
    }    
}