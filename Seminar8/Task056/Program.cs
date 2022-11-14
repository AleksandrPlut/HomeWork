// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[6, 4];

void FillArray(int[,] matr, int min, int max){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr [i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumElementArray(int[,] matr){
    int sum = 0;
    int smallestSum = 0;
    int row = 0;
    
    for (int i = 0 ; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            sum += matr[i, j];
        }
        Console.WriteLine($"Сумма чисел {i+1}-й строки = {sum}");
        if(i == 0){
            smallestSum = sum;
        }
         
        if(smallestSum > sum){
            smallestSum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.Write($"Cтрока с наименьшей суммой элементов: {row + 1}.");
}

FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
SumElementArray(array);
