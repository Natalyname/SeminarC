using static System.Console;
Clear();

WriteLine("Сколько банок сбил первый стрелок: ");
int a1 = Convert.ToInt32(ReadLine());
WriteLine("Сколько банок сбил второй стрелок: ");
int a2 = Convert.ToInt32(ReadLine());

WriteLine($"Всего сбито банок - {a1+a2-1}");
