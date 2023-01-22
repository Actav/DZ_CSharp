/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

bool isNumeric = false;
int N = 0;

while (!isNumeric) {
    Console.Write("Введите пятизначное число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out N);
}

Console.Write($"{N} -> ");
for (int i = 0; i < N; i++) {
    Console.Write((int)Math.Pow(i+1, 3) + (i < N-1 ? ", " : "\n"));
}
