using static System.Console;
Clear();

WriteLine("Введите координаты точки А: ");
Write("x = ");
int.TryParse(ReadLine(), out int ax);
Write("y = ");
int.TryParse(ReadLine(), out int ay);
WriteLine("Введите координаты точки B: ");
Write("x = ");
int.TryParse(ReadLine(), out int bx);
Write("y = ");
int.TryParse(ReadLine(), out int by);

double length = Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2));
WriteLine($"{length:f2}");