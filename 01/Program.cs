/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N = getNum();
Console.WriteLine($"N = {N} -> \"{PrintNaturalNumbers(N)}\"");

// --- FUNCs --- //
int getNum(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric && varValue < 1) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    }

    return varValue;
}

string PrintNaturalNumbers(int n) {
    if (n == 0) {
        return "";
    }

    return n + (n!=1 ? ", " : "") + PrintNaturalNumbers(n-1);
}
