/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = GenerateInt2DArray(4, 4, 0, 9);
Print2DIntArray(array);
System.Console.WriteLine("-----------");
SortArray(array);
Print2DIntArray(array);

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

void SortArray(int[,] array) {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[] temp = new int[col];

    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            temp[j] = array[i, j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        
        for (int j = 0; j < col; j++) {
            array[i, j] = temp[j];
        }
    }   
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
