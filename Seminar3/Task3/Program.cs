using static System.Console;
Clear();

WriteLine("Введите координаты точки: ");
Write("Введите x = ");
int x = int.Parse(ReadLine()!);
Write("Введите y = ");
int y = int.Parse(ReadLine()!);

if (x == 0 || y == 0)
{
    WriteLine("Ошибка");
    return;
}
if (x > 0 && y > 0)
{
    WriteLine("Первая четверть");
}
if (x < 0 && y > 0)
{
    WriteLine("Вторая четверть");
}
if  (x < 0 && y < 0)
{
    WriteLine("Третья четверть");
}
if (x > 0 && y < 0)
{
    WriteLine("Четвертая четверть");
}
