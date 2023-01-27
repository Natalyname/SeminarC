// **Задача 51:**  Задайте двумерный массив. Найдите сумму элементов, 
//                 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//                 Например, задан массив:  1 4 7 2   5 9 2 3   8 4 2 4
//                 Сумма элементов главной диагонали: 1+9+2 = 12

using static System.Console;
Clear();

WriteLine("Введите через пробел размерность матрицы и мин и макс значения: ");
string[] par = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrixArray = GetMatrixArray(int.Parse(par[0]), int.Parse(par[1]), int.Parse(par[2]), int.Parse(par[3]));

PrintMatrixArray(matrixArray);
int result = ArrayMainDiagonalSum(matrixArray);
WriteLine();
WriteLine($"Сумма элементов, находящихся на главной диагонали равна {result}");


int ArrayMainDiagonalSum(int[,] inArray)
{
    int resultSum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i==j)
            {
                resultSum += inArray[i, j];
            }
        }
    }

    return resultSum;
}


int[,] GetMatrixArray(int rows, int columns, int inMinValue, int inMaxValue)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(inMinValue, inMaxValue + 1);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}
