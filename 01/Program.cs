/*
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число 
большее, а какое меньшее.
*/

Console.WriteLine("Нахождение меньшего и большего числа из двух целых чисел");
Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32( Console.ReadLine() );  

Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32( Console.ReadLine() );  

if (numOne == numTwo) {
  Console.WriteLine("Эти числа ровны");
}
else if (numOne > numTwo) {
  Console.WriteLine($"max={numOne}, min={numTwo}");
} else {
  Console.WriteLine($"max={numTwo}, min={numOne}");
}
