// Задача 39:** Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]

using static System.Console;
Clear();
Write("Ведите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

WriteLine($"[{String.Join(",", array)}]");
ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");
//WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

int[] GetArray(int size)
{
int[] resultArray = new int[size];
for (int i = 0; i < size; i++)
{
resultArray[i] = new Random().Next(1, 10);
}
return resultArray;
}

int[] ReverseArray1(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];
}
return result;
}

void ReverseArray2(int[] inArray)
{
for (int i = 0; i < inArray.Length/2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - 1 - i];
inArray[inArray.Length - 1 - i] = temp;
}
}