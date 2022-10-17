// Написать программу которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

int SearchBigNumber(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec) return ed;
    else return dec;
}

int number = new Random().Next(10, 100);
int searchNumber = SearchBigNumber(number);
Console.WriteLine(number);
Console.WriteLine($"Big of { number } is { searchNumber } ");