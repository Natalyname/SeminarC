// **Задача 57:** Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза элемент.

using static System.Console;
Clear();

int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
WriteLine();
SearchMatrixValues(matrix);
WriteLine();


void SearchMatrixValues(int[,] inMatrix)
{
    int counter = 0;

    for (int k = 0; k < 100; k++)
    {
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                counter += inMatrix[i, j] == k ? 1 : 0;
            }
        }
        if (counter != 0) WriteLine($"Элемент {k} встречается {counter} раз(а).");
        counter = 0;
    }
}


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
    int rows = rand.Next(1, 10);      int columns = rand.Next(1, 10);
    int minValue = rand.Next(0, 2);  int maxValue = rand.Next(9, 10);
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

