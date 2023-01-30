/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] numsArr = generateNumsArr(6, -99, 100);
System.Console.WriteLine($"{arrToStr(numsArr)} -> {sumOddNum(numsArr)}");

// -- FUNCs -- //
int[] generateNumsArr(int n, int min, int max) {
    int[] arrNum = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int sumOddNum(int[] numsArr) {
    int sum = 0;
    
    for (int i = 1; i < numsArr.Length; i += 2) {
        sum += numsArr[i];
    }   

    return sum;
}

string arrToStr(int[] nums){
    return $"[{String.Join(", ", nums)}]";
}
