/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int num = 0;
bool isNumeric = false;
while (!isNumeric || num < 100 || num > 999) {
    Console.Write("Введите трехзначное число число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out num);
    if (isNumeric) {
        num = Math.Abs(num);
    }
}

int numOut = (num % 100) / 10;

Console.WriteLine(numOut);

// ------------------------- //

// Если уточнено что числа только положительные //
/*
int num = 0;
bool isNumeric = false;
while (!isNumeric) {
    Console.Write("Введите трехзначное число число: ");
    string? numIn = Console.ReadLine();
    isNumeric = int.TryParse(numIn, out num) && numIn?.Length != 3;
}

int numOut = (num % 100) / 10;

Console.WriteLine(numOut);
/**/