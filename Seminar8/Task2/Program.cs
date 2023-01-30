// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using static System.Console;
Clear();

int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
int[,] matrix2 = ExchangeRowsToColumns(matrix);
WriteLine();
PrintMatrix(matrix2);
WriteLine();


int[,] ExchangeRowsToColumns(int[,] inMatrix)
{
    if (inMatrix.GetLength(1) != inMatrix.GetLength(0))
    {
        Write($"\nЭлементы в строках и столбцах массива невозможно заменить без нарушения размерности матрицы, " 
            + $"так как она не является квадратной! "
            + $"В связи с чем размерность матрицы изменена на матрицу размерности"
            + $" [{inMatrix.GetLength(1)}, {inMatrix.GetLength(0)}]:\n"

            );
    }
    
    int[,] resultMatrix = new int[inMatrix.GetLength(1), inMatrix.GetLength(0)];
    
    for (int i = 0; i < resultMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(0); j++)
        {
            resultMatrix[j, i] = inMatrix[i, j];
        }
    }
    return resultMatrix;
}


int[,] CreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(5, 10);        int columns = rand.Next(5, 10);
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

