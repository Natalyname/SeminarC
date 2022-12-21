using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

WriteLine(a % 7==0 && a % 23==0? "Число кратно и 7, и 23" : "Число не кратно");
