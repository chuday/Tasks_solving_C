// Написать программу которая принимает на вход два числа и проверяет 
// является ли первое квадратом второго

int num1, num2, quad;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// Еще решение
int num3, num4;

Console.Write("Введите первое число: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num4 = Convert.ToInt32(Console.ReadLine());

if(num3 == num4 * num4)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");