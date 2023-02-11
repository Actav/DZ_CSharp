/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int[] nums = getNums(2);
int m = nums[0];
int n = nums[1];
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackermann(m, n)}");

// --- FUNCs --- //
int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите числа для вычисления функции Аккермана через запятую: ");
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

int Ackermann(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (m > 0 && n == 0) {
        return Ackermann(m - 1, 1);
    } else if (m > 0 && n > 0) {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    } else {
        return 0;
    }
}
