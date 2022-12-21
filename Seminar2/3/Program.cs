using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a1 = int.Parse(ReadLine()!);
int a2 = int.Parse(ReadLine()!);

WriteLine(a1%a2==0? "Первое число кратно второму" : $"Остаток от деления равен {a1 % a2}");
