/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] array = GenerateInt2DArray(4, 4, 0, 9);
int[] element = getNums(2);

Print2DArray(array);
PrintSearchArrayElement(element, array);

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

int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите позицию элемента в массиве через запятую `row,col`: ");
        string? str = Console.ReadLine();
        if (str != null) {
            (nums, isNum) = parseNums(str, length);
        }
    }

    return nums;
}

(int[], bool) parseNums(string numStr, int length) {
    string[] numsStrArr = numStr.Split(",");
    int numsStrLength = numsStrArr.Length;
    int[] nums = new int[numsStrLength];
    int tmpInt;

    for (int i = 0; i < numsStrLength; i++) {
        if (!int.TryParse(numsStrArr[i], out tmpInt)){

            return (new int[]{}, false);
        }
        nums[i] = tmpInt;
    }

    return (nums, nums.Length == length);
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

void PrintSearchArrayElement(int[] element, int[,] array) {
    int row = element[0];
    int col = element[1];
    if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1)) {
        Console.WriteLine($"Значение искомого элемента [{row},{col}]: {array[row, col]}");
    } else {
        Console.WriteLine("Элемент находится за пределами массива.");
    }
}
