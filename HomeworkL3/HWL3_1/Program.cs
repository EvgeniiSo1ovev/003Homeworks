// Задача 1 Напишите программу, которая принимает на вход любое целое число 
// и проверяет, является ли оно палиндромом. Не использовать строки
// 5142125 -> нет
// 6128216 -> да
// 782343287 -> да

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int num)
{
    if (num < 10)
    {
        System.Console.WriteLine("Введенное число должно быть минимум двухзначным");
        return false;
    }
    return true;
}

int LengthOfNumber(int num) // функция определения длины числа
{
    int lengthNum = 1;
    while (true)
    {
        num = num / 10;
        if (num > 0)
        {
            lengthNum++;
        }
        else
        {
            break;
        }
    }
    return lengthNum;
}

int Degree(int x, int y) // функция возведения числа x в степень y, при этом y - неотрицательное число
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

bool IsPalindrom(int num) // функция определения, является ли число палиндромом
{
    int N = LengthOfNumber(num);
    for (int i = 0; i <= (N - 1) / 2; i++)
    {
        int v1 = num / Degree(10, N - 1 - i) % 10;
        int v2 = num / Degree(10, i) % 10;
        if (v1 != v2)
        {
            return false;
        }
    }
    return true;
}

int number = Promt("Введите целое число");
if (ValidateNumber(number))
{
    if (IsPalindrom(number))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}