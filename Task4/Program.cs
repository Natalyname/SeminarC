using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int n=-a;

while (n <= a)
{
    Write ($"{n}");
    n = n + 1;
}