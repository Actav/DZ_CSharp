/*
Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

getMultipler();

// --- FUNCs --- //
void getMultipler(){
    System.Console.WriteLine(multipler(getNums(2)));
}

int[] getNums(int length){
    bool isNum = false;
    int[] nums = new int[]{};
    while (!isNum) {
        Console.Write($"Введите числа для возведения в степень через **: ");
        string? dotStr = Console.ReadLine();
        if (dotStr != null) {
            (nums, isNum) = parseNums(dotStr, length);
        }
    }

    return nums;
}
(int[], bool) parseNums(string numStr, int length) {
    string[] numsStrArr = numStr.Split("**");
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

// ------------------------------------------------ //

int multipler(int[] nums) {
    int result = nums[0];
    for (int i = 1; i < nums[1]; i++)
    {
        result *= nums[0] ;
    }

    return result;
}