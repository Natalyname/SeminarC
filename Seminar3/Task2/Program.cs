//По номеру дня недели вывести его название, используя switch case.

using static System.Console;
Clear();

WriteLine("Введите номер дня недели: ");
//int a = int.Parse(ReadLine()!);
bool isParse = int.TryParse(ReadLine(), out int a);
if (!isParse)
{
    WriteLine("Введено не число");
    return;
}

switch (a)
{
    case 1:
    {
        WriteLine($"{a = 1} - Понедельник");
        break;
    }
    case 2:
    {
        WriteLine($"{a = 2} - Вторник");
        break;
    }
    case 3:
    {
        WriteLine($"{a = 3} - Среда");
        break;
    }
    case 4:
    {
        WriteLine($"{a = 4} - Четверг");
        break;
    }
    case 5:
    {
        WriteLine($"{a = 5} - Пятница");
        break;
    }
    case 6:
    {
        WriteLine($"{a = 6} - Суббота");
        break;
    }
    case 7:
    {
        WriteLine($"{a = 7} - Воскресенье");
        break;
    }
    default:{
        WriteLine("Неправильно введена цифра дня недели");
        break;
    }
}
