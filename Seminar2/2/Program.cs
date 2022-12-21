using static System.Console;
Clear();

int number=new Random().Next(10, 1000);
WriteLine(number);
int a1 = number/100;
int a2 = number%10;

WriteLine($"{a1}{a2}");
