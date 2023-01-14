// Составить одномерный массив, заполненный 0 и 1 из 8 элементов.

using static System.Console;
Clear();
 
int [] arr = GetArray(10);
int [] arr1 = new int [8];

FullArray (arr1);
PrintArray(arr);
// ИЛИ PrintArray(arr1);

void FullArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(0,2);                                     
    }
}

int [] GetArray (int size)
{
    int [] array=new int [size];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(2);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i=0; i< array.Length; i++)
    {
        WriteLine($"{array[i]}");
    }
}