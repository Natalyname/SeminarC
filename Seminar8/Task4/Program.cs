// **Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

using static System.Console;
Clear();

WriteLine("Start");
int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);
int minValue =  GetMinMatrixValue(matrix);
int minCounts =  CountMatrixValue(matrix, minValue);
WriteLine("минимальный элемент-> " + minValue);
WriteLine(minCounts + " раз");
int[,] matrix2 = ShrinkMatrixByAdress(matrix, minValue);
WriteLine();
PrintMatrix(matrix2);

int[,] ShrinkMatrixByAdress(int[,] inMatrix, int inMinValue)
{
    if (inMatrix.GetLength(0) < 1 || inMatrix.GetLength(1) < 1) return inMatrix;
    int row = 0; int column = 0;
    for (int i = inMatrix.GetLength(0) - 1; i >= 0; i--) {
        for (int j = inMatrix.GetLength(1) - 1; j >= 0; j--) {
            if (inMatrix[i, j] == inMinValue) {
                row = i;
                column = j;
            }
        }
    }
    WriteLine($"Адрес минимального: {row}, {column}");
    int[,] resultMatrix = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (i < row && j < column) {resultMatrix[i, j] = inMatrix[i, j];}
            if (i < row && j > column) {resultMatrix[i, j - 1] = inMatrix[i, j];}
            if (i > row && j > column) {resultMatrix[i - 1, j - 1] = inMatrix[i, j];}
            if (i > row && j < column) {resultMatrix[i - 1, j] = inMatrix[i, j];}
            // resultMatrix[i, j] = (i < row && j < column) ? inMatrix[i, j] 
            //     : (i < row && j > column) ? inMatrix[i, j];
                                  
        }    
    }

    return resultMatrix;
}


int CountMatrixValue(int[,] inMatrix, int inMinValue)
{
    int counter = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            counter += inMinValue == inMatrix[i, j] ? 1 : 0;
        }
    }
    return counter;
}


int GetMinMatrixValue(int[,] inMatrix)
{
    int result = inMatrix[0, 0]; 
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            result = ( result > inMatrix[i,j] ) ? inMatrix[i, j] : result;
        }
    }
    return result;
} 



int[,] CreateRandomMatrix(){
    Random rand = new Random();
    int rows = rand.Next(1, 11);        int columns = rand.Next(1, 11); 
    int minValue = rand.Next(-10, 0);  int maxValue = rand.Next(0, 10);
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

