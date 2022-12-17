using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

WriteLine($"Квадрат числа {a} равен {a*a}");
