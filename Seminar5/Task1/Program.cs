// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

using static System.Console;
Clear();

Write("Введите размер массива, min и max через пробел: ");
string [] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int [] array=GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();

int negativeSum = 0;
int positiveSum = 0;

foreach (int a in array)
{
    negativeSum += a < 0 ? a : 0;
    positiveSum += a > 0 ? a : 0;
}
WriteLine($"{negativeSum}  {positiveSum}");


int[] GetArray (int size, int MinValue, int MaxValue) //метод формирования массива
{
    int[] resultArray = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray [i] = rnd.Next(MinValue, MaxValue+1);
    }
    return resultArray;
}


void PrintArray(int[] inArray)   //Метод красиво выврдит массив в квадратных скобках через запятые.
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
       Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}