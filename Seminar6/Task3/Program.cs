// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using static System.Console;
Clear();

int num = AskUserForNumber("Введите число для перевода в двоичную систему: ");
WriteLine($"\nДесятичное число {num} в двоичном исчислении будет {decimalToBinary(num)}.\n");

string decimalToBinary(int inNum)
{
    if (inNum ==0) return "0";
    string result = string.Empty;
    //остаток - remainder -> var rem
    int rem;
    while (inNum > 0)
    {
        rem = inNum %2;
        inNum /=2;
        result = rem.ToString() + result;
    }
    return result;
}

int AskUserForNumber (string inPrompt)
{
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum))
    {
        Write (inPrompt);
        userInput = ReadLine()!;
    }
    return resultNum;
}