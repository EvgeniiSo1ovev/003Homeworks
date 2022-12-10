//Задача 2: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Summa(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int number = Prompt($"Введите число: ");
Console.WriteLine($"Сумма цифр в числе {number} равна {Summa(number)}");