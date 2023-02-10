/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = GenerateInt3DArray(2, 2, 2, 10, 100);
Print3DArray(array);


// --- FUNCs --- //
int[,,] GenerateInt3DArray(int m, int n, int o,  int min, int max) {
    int number;
    int[,,] array = new int[m, n, o];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                
                do {
                    number = random.Next(min, max);
                } while (ArrayContains(array, number));
                array[i, j, k] = number;
            }
        }
    }

    return array;
}

bool ArrayContains(int[,,] array, int number) {
    foreach (int item in array) {
        if (item == number) {
            return true;
        }
    }

    return false;
}

void Print3DArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
