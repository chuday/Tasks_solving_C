// Написать программу которая принимает на вход два числа и проверяет
// является ли одно квадратом другого

bool Sqaure(int num1, int num2)
{
    if ( num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
}

Console.Write("Введи первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

bool result = Sqaure(numb1, numb2);

Console.Write(result);