using static System.Console;
Clear();

int i = 1;
Write("Введите число для вывода таблицы квадратов от 1 до числа: ");
int.TryParse(ReadLine(), out int n);

while (i < n+1)
{
    WriteLine($"Квадрат числа {i} = {Math.Pow(i,2)}");
    i++;
}