// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[5, 4];

void FillArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr [i, j] = new Random().Next(1, 100);
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

void SortingArray(int[,] matr){
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            for (int l = 0; l < matr.GetLength(1); l++){
                if (matr[i,j] > matr[i,l]){
                    temp = matr[i,l];
                    matr[i,l] = matr[i,j];
                    matr[i,j] = temp;
                }
            }
        }
        
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SortingArray(array);
PrintArray(array);