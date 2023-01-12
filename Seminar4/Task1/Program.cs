// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

int Count = Numbers(number);
WriteLine($"Количестве цифр в числe {number} - {Count}");

int Numbers(int A)
{
    int result = 0;
    while (A>0)
    {
        A=A/10;
        result++;
    }
    return result;
}