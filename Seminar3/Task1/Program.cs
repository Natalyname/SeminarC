using static System.Console;
Clear();

Write("Введите номер четверти: ");
int i = int.Parse(ReadLine()!);

switch (i)
{
    case 1:
    {
        WriteLine("x > 0 y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0 y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0 y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0 y < 0");
        break;
    }
    default:
    {
        WriteLine("Ошибка");
        break;
    }
}