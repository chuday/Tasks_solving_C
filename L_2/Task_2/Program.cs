// Написать программу которая будет принимать на вход два числа и выводить 
// является ли второе число кратным первому

bool IsBriefly(int num1, int num2)
{
    if (num1 % 2 == 0) return true;
    else return false;
}

Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool briefly = IsBriefly(num1,  num2);

Console.WriteLine(briefly);
