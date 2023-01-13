// Напишите программу, которая принимает на вход число N, и выдает сумму чисел, на которые число N делится
//без остатка.

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum (number);
WriteLine($"Сумма равна {sum}");

    //int GetSum (int N)
    //{
    //int result=0;
    //for (int i=1; i<=N; i++)
    //{
      //if (N%i ==0)
      //{
        //result+=i;
      //}
      //return result;
      //}

                     //ИЛИ:
                     
      int GetSum (int N)
      {
      int result=0;
      int i=1;
      while (i<=N)
      {
        if (N%i==0)
        {
            result+=i;
        }
        i++;
      }
        return result;
    }
    
    //return result;
