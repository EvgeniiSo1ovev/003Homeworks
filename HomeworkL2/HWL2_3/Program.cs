// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

bool ValidateNumber(int number)
{
    if(number >= 100)
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет");
    return false;
}

int FindDivider(int number)
{
    int del = 1000;
    while(true)
    {
        if(number/del == 0)
        {
            del = del / 1000;
            break;
        }
        del = del * 10;
    }
    return del;
}

int number = Promt("Введите число");
if(ValidateNumber(number))
{
    int divider = FindDivider(number);
    int thirdOfNumber = number / divider % 10;
    System.Console.WriteLine($"Третья цифра заданного числа: {thirdOfNumber}");
}