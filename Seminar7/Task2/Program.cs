// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]));
PrintMatrixArray(array);


int[,] GetMatrixArray(int rows, int columns)
{
int[,] resultArray=new int[rows,columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
resultArray[i,j] = i + j;
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
Write($"{inArray[i,j],3} ");
}
WriteLine();
}
}
