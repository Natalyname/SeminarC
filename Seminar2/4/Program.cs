//Программа принимает на вход 2 числа, на выходе выдает только знак сравнения этих 2 чисел.

using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a1 = int.Parse(ReadLine()!);
int a2 = int.Parse(ReadLine()!);

WriteLine(a1==a2 ? "числа равны" : a1>a2 ? ">" : "<");
