// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

bool ValidateNumber(int number)
{
    if(number >= 100 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Введенное число не трехзначное");
    return false;
}

int number = Promt("Введите трехзначное число");
if(ValidateNumber(number))
{
    int secondOfNumber = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра введенного трехзначного числа: {secondOfNumber}");
}