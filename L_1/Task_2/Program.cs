// Написать программу которая на вход принимает одно число N а на выходе показывает 
// все целые числа в промежутке от -N до N

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " " );
    current++;
}