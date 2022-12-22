using static System.Console;
Clear();

int number1 = new Random().Next(1, 10);
int number2 = new Random().Next(1, 10);
int number3 = new Random().Next(1, 10);
WriteLine(number1);
WriteLine(number2);
WriteLine(number3);

int max = number1;
int min = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
if (number2 < min) min = number2;
if (number3 < min) min = number3;

WriteLine();
WriteLine(max-min);