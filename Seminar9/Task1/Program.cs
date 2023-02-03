// Задайте значение N. Напишите программу вывода всех натуральных чисел от 1 до N.

using static System.Console;
Clear();

string result=GetNumbers(5);
WriteLine(result);
PrintNumbers(10);

string GetNumbers(int num)                 //собрал строку и распечатал
{
    if(num==1) return num.ToString();   
    else return $"{GetNumbers(num-1)},{num}";
}


// string GetNumbers1(int num)                
// {
//     return ((num==1)) ? num.ToString() : "{GetNumbers(num-1)},{num}";
// }

void PrintNumbers(int num)              //распечатывает в процессе
{
    if(num==1) Write(num);              
    else
    {
       PrintNumbers(num - 1);
       Write($",{num}");
    }
}