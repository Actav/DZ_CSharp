/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

float[,] array = GenerateArray(3, 4, -9, 9);
PrintArray2D(array);

// --- FUNCs --- //
float[,] GenerateArray(int m, int n, int min, int max)
{
    Random random = new Random();
    float[,] array = new float[m, n];

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            float randNum = random.NextSingle() * (max - min) + min;
            array[i,j] = (float)Math.Round(randNum, 1);
        }
    }

    return array;
}

void PrintArray2D(float[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<float> currentRow = new List<float>();
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRow.Add(array[i,j]);
        }
        Console.WriteLine(string.Join("\t", currentRow));
    }
}
