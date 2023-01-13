//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

using static System.Console;
Clear();

Write ("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);

int sum1 = GetSum(number1);
WriteLine($"Сумма чисел от 1 до {number1} = {sum1}");

Write ("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);

int sum2 = GetSum(number2);
WriteLine($"Сумма чисел от 1 до {number2} = {sum2}");

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

