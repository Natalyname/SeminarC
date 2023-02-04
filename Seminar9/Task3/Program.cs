//**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//  453 -> 12

using static System.Console;
Clear();

WriteLine("Введите число: ");
int N = int.Parse(ReadLine()!);

GetNum(N);
WriteLine($"Сумма цифр числа {N} равна {GetNum(N)}");

int GetNum (int num)
{
if (num == 0) return num;
else return GetNum (num/10) + num % 10;
}