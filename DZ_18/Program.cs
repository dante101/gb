// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа через Enter, если хотите прекратить ввод, то введите команду  'stop' ");
int numbers;
int count = 0;
string stopProgram = "stop";
while (true)
{
    string? num = Console.ReadLine();
    if (num == stopProgram)
    {
        break;
    }
    numbers = Convert.ToInt32(num);
    if (numbers > 0)
    {
        count ++;
    }
}
Console.WriteLine($"Чисел больше 0 :{count}");