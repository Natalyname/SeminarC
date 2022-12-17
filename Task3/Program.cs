using static System.Console;
Clear();

WriteLine("Введите число от 1 до  7");
int a = int.Parse(ReadLine()!);

if(a > 7)

{
    WriteLine("Введено неверное число");
}
    if (a == 1)
    {
         WriteLine("День недели - понедельник");
    }
    if (a == 2)
    {
        WriteLine("День недели - вторник");
    }
    if (a == 3)
    {
        WriteLine("День недели - среда");
    }
    if (a == 4)
    {
        WriteLine("День недели - четверг");
    }
    if (a == 5)
    {
        WriteLine("День недели - пятница");
    }
    if (a == 6)
    {
        WriteLine("День недели - суббота");
    }
    if (a == 7)
    {
        WriteLine("День недели - воскресенье");
    }

 
