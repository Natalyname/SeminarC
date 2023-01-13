//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

using static System.Console;
Clear();

Write ("Введите число: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Сумма чисел от 1 до {number} = {sum}");

int GetSum (int A)
{
    int result=0;
    while (A>0)
    {
        result+=A;
        A--;
    }
    return result;
}

