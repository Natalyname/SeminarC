// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

int a = AskUserForNumber("Введите сторону треугольника а: ");
int b = AskUserForNumber("Введите сторону треугольника b: ");
int c = AskUserForNumber("Введите сторону треугольника c: ");

WriteLine(IsTriangle (a, b, c) ? $"\nТреугольник со сторонами {a}, {b}, {c} существует.\n" : $"\n Треугольника со сторонами {a}, {b}, {c} не существует.\n");

bool IsTriangle(int inA, int inB, int inC)
{
    return (inA + inB > inC && inA +inC >inB && inB + inC > inA);
}

int AskUserForNumber(string inPrompt)
{
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum))
    {
        Write(inPrompt);
        userInput = ReadLine()!;
    }
    return resultNum;
}