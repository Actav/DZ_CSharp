/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]
*/

int[] nums = getNums(8);
printArr(nums);

// --- FUNCs --- //
void printArr(int[] nums){
    System.Console.Write($"[{String.Join(",", nums)}]\n");
}

int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите числа через запятую: ");
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