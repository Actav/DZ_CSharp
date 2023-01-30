/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

float[] floatNumsArr = generateFloatNumsArr(6, 0, 100);
System.Console.WriteLine($"{arrToStr(floatNumsArr)} -> {sumMinMaxFloatNums(floatNumsArr)}");

// -- FUNCs -- //
float[] generateFloatNumsArr(int n, float min, float max) {
    Random rnd = new Random();
    float[] arrNum = new float[n];

    for (int i = 0; i < arrNum.Length; i++) {
        float randNum = rnd.NextSingle() * (max - min) + min;
        arrNum[i] = (float)Math.Round(randNum, 3);
    }

    return arrNum;
}

float sumMinMaxFloatNums(float[] floatNumsArr) {
    float min = floatNumsArr[0];
    float max = floatNumsArr[0];

    for (int i = 1; i < floatNumsArr.Length; i++) {
        if (min > floatNumsArr[i]) {
            min = floatNumsArr[i];
        } else if (max < floatNumsArr[i]) {
            max = floatNumsArr[i];
        }   
    }

    return max - min;
}

string arrToStr(float[] nums){
    return $"[{String.Join(", ", nums)}]";
}
