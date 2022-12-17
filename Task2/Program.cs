using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);

if (a*a ==b)
{
    WriteLine($"Число {b} является квадратом числа {a}");
}
else
{
    WriteLine($"Число {b} не является квадратом числа {a}");
}