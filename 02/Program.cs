/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double b1 = getDoubleVal("b1");
double k1 = getDoubleVal("k1");
double b2 = getDoubleVal("b2");
double k2 = getDoubleVal("k2");

double x = GetIntersectionX(b1, k1, b2, k2);
if (double.IsNaN(x))
{
    return;
}
double y = GetIntersectionY(x, k1, b1);

Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");


// ---- FUNCs --- //
double getDoubleVal(string name){
    double value;
    Console.Write($"Введите значение для {name}: ");
    while (!double.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine($"Ошибочный ввод. Введите значение для {name}: ");
    }

    return value;
}

double GetIntersectionX(double b1, double k1, double b2, double k2) 
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые пралелны.");
        return double.NaN;
    }

    return (b2 - b1) / (k1 - k2);
}

double GetIntersectionY(double x, double k1, double b1)
{
    return k1 * x + b1;
}