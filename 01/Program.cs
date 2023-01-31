/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("ВВедите М чисел через пробел: ");
string input = Console.ReadLine() ?? "";
int count = CountPositive(input);
Console.WriteLine($"Введено положительных чисел: {count}");


// --- FUNCs --- //
int CountPositive(string input)
{
    string[] numbers = input.Split(' ');
    int count = 0;
    foreach (string number in numbers)
    {
        if (double.TryParse(number, out double value) && value > 0)
        {
            count++;
        }
    }
    return count;
}
