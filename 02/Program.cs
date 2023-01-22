/*
Задача 21
Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = getVar("A", "x");
int y1 = getVar("A", "y");
int z1 = getVar("A", "z");

int x2 = getVar("B", "x");
int y2 = getVar("B", "y");
int z2 = getVar("B", "z");

double res = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
System.Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Math.Round(res, 2)}");

// --- FUNCs --- //
int getVar(string dotName, string varName){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите координату {varName} точки {dotName}: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    }

    return varValue;
}

// --- Если мы знаем что такое массивы --- //
/*
var dotA = getDot("A");
var dotB = getDot("B");

double res = 0;
for (int i = 0; i < dotA.Length; i++) {
    res += Math.Pow(dotB[i]-dotA[i], 2);
}
res = Math.Sqrt(res);

System.Console.WriteLine($"A ({String.Join(",", dotA)}); B ({String.Join(",", dotB)}) -> {Math.Round(res, 2)}");

// --- FUNCs --- //
(int[], bool) parseDot(string numStr) {
    string[] numsStr = numStr.Split(",");
    int numsStrLength = numsStr.Length;
    int[] nums = new int[numsStrLength];

    int tmpInt;
    for (int i = 0; i < numsStrLength; i++) {
        if (!int.TryParse(numsStr[i], out tmpInt)){
            
            return (new int[]{}, false);
        }
        nums[i] = tmpInt;
    }

    return (nums, nums.Length == 3);
}

int[] getDot(string dotName){
    bool isDot = false;
    int[] dot = new int[]{};

    while (!isDot) {
        Console.Write($"Введите через запятую координаты точки {dotName}: ");
        string? dotStr = Console.ReadLine();
        if (dotStr != null) {
            (dot, isDot) = parseDot(dotStr);
        }
    }

    return dot;
}
/**/