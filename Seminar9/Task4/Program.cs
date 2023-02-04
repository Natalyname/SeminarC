// **Задача 69:** Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using static System.Console;
Clear();

WriteLine("Введите число: ");
int A = int.Parse(ReadLine()!);
WriteLine("Введите степень, в которую нужно возвести число: ");
int B = int.Parse(ReadLine()!);
GetNum (A,B);
WriteLine($"{A} в {B} степени равно {GetNum(A,B)}");

int GetNum (int a, int b)
{
if (b == 1) return a;
else return GetNum (a, b-1) * a; 
}