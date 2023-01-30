/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] numsArr = generateNumsArr(6, 100, 1000);
System.Console.WriteLine($"{arrToStr(numsArr)} -> {countEvenNum(numsArr)}");

// -- FUNCs -- //
int[] generateNumsArr(int n, int min, int max) {
    int[] arrNum = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

int countEvenNum(int[] numsArr) {
    int count = 0;
    
    foreach (var num in numsArr) {
        if (num % 2 == 0) {
            count++;
        }
    }

    return count;
}

string arrToStr(int[] nums){
    return $"[{String.Join(", ", nums)}]";
}
