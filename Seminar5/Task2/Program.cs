// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.

using static System.Console;
Clear();

int [] array = {-95, -5, -2, 0, 4, 8, 32};

ReverseArray(array);
PrintArray(array);

void ReverseArray(int[] inarray)
{
    for (int i = 0; i < inarray.Length; i++)    
    {
        inarray[i] *= -1;
    }
}

void PrintArray (int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length-1]}]");
}