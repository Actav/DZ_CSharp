/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int[] nums = getNums(2);
int M = nums[0], N = nums[1];
Console.WriteLine($"M = {M}; N = {N} -> {SumNaturalNumbers(M, N)}");

// --- FUNCs --- //
int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите два числа через запятую: ");
        string? dotStr = Console.ReadLine();
        if (dotStr != null) {
            (nums, isNum) = parseNums(dotStr, length);
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

int SumNaturalNumbers(int m, int n) {
    if (m == n) {
        return m;
    }

    return m + SumNaturalNumbers(m + 1, n);
}
