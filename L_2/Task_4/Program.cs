// Написать программу которая принимает на вход число и проверяет
// кратное оно одневременно 7 и 23

bool IsBriefly(int n)
{
    if (n % 7 == 0 && n % 23 == 0) return true;
    else return false;
}

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
bool result = IsBriefly(number);

Console.WriteLine(result);
