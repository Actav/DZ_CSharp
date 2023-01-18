/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


bool isNumeric = false;
int num = 0;

while (!isNumeric) {
    Console.Write("Введите число: ");
    isNumeric = int.TryParse(Console.ReadLine(), out num);
}

System.Console.Write(num + " -> ");
num = Math.Abs(num);

if (num > 99) {
    while (num > 999 ) {
        num /= 10; 
    }
    System.Console.WriteLine(num % 10);
} else {
    System.Console.WriteLine("третьей цифры нет");
}