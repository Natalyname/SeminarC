using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a1 = int.Parse(ReadLine()!);
int a2 = int.Parse(ReadLine()!);

WriteLine(a1*a1==a2 || a2*a2==a1? "Одно число является квадратом другого" : "не являются");
