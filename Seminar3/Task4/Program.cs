using static System.Console;
Clear();

WriteLine("Введите количество деталей за смену: ");
int quantity = int.Parse(ReadLine()!);
int result = quantity%6;

if (result == 0)
{
 WriteLine($"Младшие токари сделали по {quantity/6} шт., старший - {quantity/6*4} шт.");
}
else 
{
    WriteLine("Старший токарь ошибся");
}