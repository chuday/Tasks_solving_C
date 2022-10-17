// Напишите программу которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа

int DeleteSecodNumber(int num)
{
    int num1 = num / 100;
    int num3 = num % 10;
    return num1 * 10 + num3;
}

int number = new Random().Next(100, 1000);
int result = DeleteSecodNumber(number);

Console.WriteLine(number);
Console.WriteLine(result);
