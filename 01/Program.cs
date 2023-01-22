/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения
типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
14212 -> нет
12821 -> да
23432 -> да
*/


bool isNumeric = false;
int num = 0;

while (!isNumeric) {
    Console.Write("Введите пятизначное число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out num);
    if (isNumeric) {
        isNumeric = num > 9999 && num < 100000; 
    }
}

Console.WriteLine($"{num} -> {(CheckNumsToPalindrome(num) ? "да" : "нет")}");

// --- FUNCs --- //
bool CheckNumsToPalindrome(int num) {
    for (int i = 4, j = 1; i > 2; i--, j++) {
        int numStart = (num/(int)Math.Pow(10, i)) % 10;

        int jPow = (int)Math.Pow(10, j);
        int numLast = num%jPow / (jPow / 10);
        
        if (numStart != numLast) {

            return false;
        }
    }

    return true;
}
