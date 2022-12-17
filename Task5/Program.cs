using static System.Console;
Clear ();

WriteLine("Введите число от 100 до 999");
int a = int.Parse(ReadLine()!);

WriteLine($"Последняя цифра числа {a} равна {a % 10}");