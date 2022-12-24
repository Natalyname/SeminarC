using static System.Console;
Clear();

WriteLine("Введите количество деталей: ");
int detal = int.Parse(ReadLine()!);
WriteLine("Введите количество токарей младшего разряда: ");
int count_tokar_1 = int.Parse(ReadLine()!);
WriteLine("Введите количество токарей старшего разряда: ");
int count_tokar_4 = int.Parse(ReadLine()!);
int tokar_1 = 1;
int tokar_4 = 2*(tokar_1+tokar_1);
int sum_proizvodstvo = tokar_1*count_tokar_1+tokar_4*count_tokar_4;

if (detal % sum_proizvodstvo == 0)
{
    WriteLine("Это правда");
    WriteLine($"Каждый токарь младшего разряда сделал {detal/sum_proizvodstvo*tokar_1} шт.");
    WriteLine($"Каждый токарь старшего разряда сделал {detal/sum_proizvodstvo*tokar_4} шт.");
}
else WriteLine("Они лгут");

