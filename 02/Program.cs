/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int num = getVar();
int summ = summNumDigit(num);

System.Console.WriteLine(summNumDigit(num));

// --- FUNCs --- //
int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
        varValue = Math.Abs(varValue);
        
        if (varValue < 0) {
            isNumeric = false;
        }
    }

    return varValue;
}

int summNumDigit(int num) {
    int summ = 0;
    while (num != 0)
    {
        summ += num % 10;
        num /= 10;
    }

    return summ;
}

