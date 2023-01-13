// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int multy = GetMulty(number);
WriteLine($"Произведение чисел от 1 до {number} = {multy}");

int GetMulty (int A)
{
    int result=1;
    while (A>0)
    {
    result *=A;
    A --;
    }
    return result;
}