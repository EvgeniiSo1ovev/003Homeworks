// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. Не использовать строки
// 6 -> да
// 7 -> да
// 1 -> нет

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

bool ValidateNumber(int number)
{
    if(number >= 1 && number <8)
    {
        return true;
    }
    System.Console.WriteLine("Цифра вне диапазона дней недели");
    return false;
}

int number = Promt("Введите цифру, обозначающую день недели (1 - 7)");
if(ValidateNumber(number))
{
    if(number == 6 || number == 7)
    {
        System.Console.WriteLine($"Да, {number}-й день недели является выходным");
    }
    else
    {
        System.Console.WriteLine($"Нет, {number}-й день недели не является выходным");
    }
}