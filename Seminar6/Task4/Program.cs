// Проверить, счастливый ли трамвайный билет.

using static System.Console;
Clear();

Write("Введите номер билета: ");
int a = int.Parse(ReadLine()!);
WriteLine(LuckyTicket(a));

bool LuckyTicket(int num)
{
    int result1 = 0;
    for (int i = 0; i < 3; i++)
    {
        result1 = result1 + (num%10);
        num/=10;
    }

    int result2 = 0;
    for (int i = 0; i < 3; i++)
    {
       result2 = result2 + (num % 10);
       num/=10;   
    }
    return (result1 == result2);
    
    //if (result1 == result2) return true;
    //else return false;
}