// Какого цвета клетка шахматной доски, если начинается с черной

using static System.Console;
Clear();

Write("Введите адрес клетки: ");
int[] addres = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine(isBlack(addres) ? "Черная" : "Белая");

bool isBlack (int[] addres){
    if(addres[0] %2 == 0) return addres[1] % 2 == 0;
    else return addres[1] % 2 != 0;
}