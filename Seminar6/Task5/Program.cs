// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);
Fibonachi(number);

void Fibonachi(int number)
{
    int temp, num1 = 0, num2 = 1;
    Write($"{num1} {num2} ");
    for (int i = 2; i < number; i++)
    {
        temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Write($"{num2} ");
    }
}