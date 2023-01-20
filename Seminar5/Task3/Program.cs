// Задача 33:** Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да.

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int n = int.Parse(ReadLine()!);
int [] arr = GetArray(n);
WriteLine("Введите число: ");
int.TryParse(ReadLine(), out int number);

printArray(arr);
WriteLine();
WriteLine(ArrayLookUp(arr,number)? $"число {number} присутствует в массиве" : $"заданного числа {number} нет в массиве");

bool ArrayLookUp(int[] inArray, int num)
{
    foreach (var i in inArray)
    {
        if(num==i) return true;
    }
    return false;
}

int[] GetArray(int size)
{
int[] resultArray = new int [size]; 
 
    Random random = new Random(); 
    for (int i = 0; i < size; i++) 
    { 
        resultArray[i] = random.Next(0, 100); 
    } 
 
    return resultArray; 
}

void printArray(int[] array){ 
    Write("["); 
    for (int i = 0; i < array.Length - 1; i++) 
    { 
        Write($"{array[i]}, "); 
    } 
 
    Write($"{array[array.Length - 1]}]"); 
}