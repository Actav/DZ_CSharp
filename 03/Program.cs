/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = GenerateInt2DArray(5, 5, 0, 9);
Print2DArray(array);

printAverage(AverageArrayCol(array));

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

void Print2DArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRow.Add(array[i,j]);
        }
        Console.WriteLine(string.Join("  ", currentRow));
    }
}

float[] AverageArrayCol(int[,] array) {
    int rowCount = array.GetLength(0);
    int colCount = array.GetLength(1);
    float[] outArray = new float[colCount];

    for (int i = 0; i < rowCount; i++) {
        for (int j = 0; j < colCount; j++) {
            outArray[j] += (float)array[i,j] / rowCount;
        }
    }
    

    return outArray;
}

void printAverage(float[] nums){
    System.Console.WriteLine();
    System.Console.Write($"Среднее арифметическое каждого столбца: {String.Join("; ", nums)}.\n");
}
