/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool isNumeric = false;
int numDay = 0;

while (!isNumeric || !(numDay > 0 && numDay < 8)) {
    Console.Write("Введите день недели: ");
    isNumeric = int.TryParse(Console.ReadLine(), out numDay);
}
Console.WriteLine($"{numDay} -> {(numDay > 5 ? "да" : "нет")}"); 
 