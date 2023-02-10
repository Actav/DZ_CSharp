/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[] size = getNums(2);
int[,] spiralArray = GenerateSpiralArray(size);
PrintArray(spiralArray);

// --- FUNCs --- //
int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите размер спирали через * (4*4): ");
        string? dotStr = Console.ReadLine();
        if (dotStr != null) {
            (nums, isNum) = parseNums(dotStr, length);
        }
    }

    return nums;
}
(int[], bool) parseNums(string numStr, int length) {
    string[] numsStrArr = numStr.Split("*");
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

int[,] GenerateSpiralArray(int[] size) {
    int x = size[0];
    int y = size[1];
    int[,] array = new int[x, y];

    int number = 1;
    int startRow = 0;
    int endRow = x - 1;
    int startColumn = 0;
    int endColumn = y - 1;

    while (number <= x * y) {
        for (int i = startColumn; i <= endColumn; i++) {
            array[startRow, i] = number;
            number++;
        }
        startRow++;

        for (int i = startRow; i <= endRow; i++) {
            array[i, endColumn] = number;
            number++;
        }
        endColumn--;

        if (startRow <= endRow) {
            for (int i = endColumn; i >= startColumn; i--) {
                array[endRow, i] = number;
                number++;
            }
            endRow--;
        }

        if (startColumn <= endColumn) {
            for (int i = endRow; i >= startRow; i--) {
                array[i, startColumn] = number;
                number++;
            }
            startColumn++;
        }
    }

    return array;
}

void PrintArray(int[,] array) {
    int number = array.GetLength(0)*array.GetLength(1);
    int numberOfDigits = (int)Math.Floor(Math.Log10(number) + 1);
    
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{{0:D{numberOfDigits}}} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

