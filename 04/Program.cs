/*
Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает 
все чётные числа от 1 до N.
*/

Console.WriteLine("Проерка является ли введенное число четным");
Console.Write("Введите число: ");
int length = Convert.ToInt32( Console.ReadLine() );

for (int i = 2; i <= length; Console.Write(i + (i != length ? ", " : "\n")), i += 2);
