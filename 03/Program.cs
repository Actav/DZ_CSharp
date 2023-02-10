/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] firstMatrix = GenerateInt2DArray(5, 7, 0, 9);
int[,] secondMatrix = GenerateInt2DArray(7, 5, 0, 9);
int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

Print2DIntArray(firstMatrix);
Print2DIntArray(secondMatrix);

MatrixMultiplication(firstMatrix, secondMatrix, resultMatrix);
Print2DIntArray(resultMatrix);

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
        Console.WriteLine(string.Join("\t", currentRow));
    }
    Console.WriteLine();
}

void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix) {
    int rowsFirst = firstMatrix.GetLength(0);
    int columnsFirst = firstMatrix.GetLength(1);
    int rowsSecond = secondMatrix.GetLength(0);
    int columnsSecond = secondMatrix.GetLength(1);

    if (columnsFirst != rowsSecond) {
        Console.WriteLine("Матрицы не согласованны.");
    } else {
        for (int i = 0; i < rowsFirst; i++) {
            for (int j = 0; j < columnsSecond; j++) {
                int sum = 0;
                for (int k = 0; k < columnsFirst; k++) {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
}



