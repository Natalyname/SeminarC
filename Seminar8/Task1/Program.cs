// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
Clear();

int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
ExchangeRowsFirstToLast(matrix);
WriteLine();
PrintMatrix(matrix);


void ExchangeRowsFirstToLast(int[,] inMatrix)
{
    int temp = 0;
    for (int i = 0; i < inMatrix.GetLength(1); i++)
    {
        temp = inMatrix[0, i];
        inMatrix[0, i] = inMatrix[inMatrix.GetLength(0) - 1 , i];
        inMatrix[inMatrix.GetLength(0) - 1 , i] = temp;      
    }
}



int[,] CreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(1, 11);        int columns = rand.Next(1, 11); 
    int minValue = rand.Next(-100, 0);  int maxValue = rand.Next(0, 101);
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            resultArray[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return resultArray;
}

void PrintMatrix(int[,] inMatrix){
    for (int i = 0; i < inMatrix.GetLength(0); i++){
        for (int j = 0; j < inMatrix.GetLength(1); j++){
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}
