// Задача 54.1 : Задайте двумерный массив. Напишите программу, которая упорядочит элементы по убыванию (или возрастанию).

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
        for (int k = 0; k < matr.GetLength(0); k++){
            for (int j = 0; j < matr.GetLength(1); j++){
                for (int l = 0; l < matr.GetLength(1); l++){
                    if (matr[i,j] < matr[k,l]){
                        temp = matr[k,l];
                        matr[k,l] = matr[i,j];
                        matr[i,j] = temp;
                    }
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