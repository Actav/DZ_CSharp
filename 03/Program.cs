/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

bool isNumeric = false;
int N = 0;

while (!isNumeric) {
    Console.Write("Введите число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out N);
}

Console.Write($"{N} -> ");
if (N == 0) {
    Console.Write("0\n");
} else {
    int i = 0;
    while ((N > 0 && i < N) || (N < 0 && i > N)) {
        i = N > 0 ? i+1 : i-1;
        double cubeN = Math.Pow(i, 3);
        Console.Write(cubeN + (Math.Abs(i) < Math.Abs(N) ? ", " : "\n"));
    }
}
