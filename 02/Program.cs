/*
Задача 4: Напишите программу, которая принимает
на вход три числа и выдаёт максимальное из
этих чисел
*/

Console.WriteLine("Нахождение наибольшего числа из трех целых чисел");
Console.Write("Введите первое число: ");
int max = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32( Console.ReadLine() );

if (max < num2) {
    max = num2;
}
if (max < num3) {
    max = num3;
}
Console.WriteLine($"Максимальное число {max}");
