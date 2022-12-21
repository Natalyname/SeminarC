using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a1 = Convert.ToInt32(ReadLine());
int a2 = Convert.ToInt32(ReadLine());

WriteLine(a1*a1==a2 ? $"Число {a2} является квадратом числа {a1}" 
: a2*a2==a1 ? $"Число {a1} является квадратом числа {a2}" : "Ни одно из чисел не является квадратом другого");
