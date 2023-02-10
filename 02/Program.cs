/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] array = GenerateInt2DArray(4, 4, 0, 9);
Print2DIntArray(array);
int rowWithSmallestSum = GetRowSmallestSum(array);
Console.WriteLine($"Строка с наименьшей суммой: {++rowWithSmallestSum}");

// --- FUNCs --- //

int[,] GenerateInt2DArray(int m, int n, int min, int max) {
    Random random = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = random.Next(min, max + 1);
        }
    }

    return array;
}

void Print2DIntArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRow.Add(array[i,j]);
        }
        Console.WriteLine(string.Join("  ", currentRow));
    }
}

int GetRowSmallestSum(int[,] array) {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int rowSmallestSum = 0;
    int smallestSum = int.MaxValue;

    // Перебор каждой строки в массиве
    for (int i = 0; i < row; i++) {
        int sum = 0;
        for (int j = 0; j < col; j++) {
            sum += array[i, j];
        }

        if (sum < smallestSum) {
            rowSmallestSum = i;
            smallestSum = sum;
        }
    }

    return rowSmallestSum;
}
