// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

(double?, double?) GetXY(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return (x, y);
    }
    return (null, null);
}

double b1 = Prompt("Введите значение переменной b1 уравнения y = k1 * x + b1: ");
double k1 = Prompt("Введите значение переменной k1 уравнения y = k1 * x + b1: ");
double b2 = Prompt("Введите значение переменной b2 уравнения y = k2 * x + b2: ");
double k2 = Prompt("Введите значение переменной k2 уравнения y = k2 * x + b2: ");
(double? xCoord, double? yCoord) = GetXY(b1, k1, b2, k2);
if (xCoord != null)
{
    System.Console.WriteLine($"Координата точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, равна ({xCoord}, {yCoord})");
}
else
{
    System.Console.WriteLine("Прямые параллельны");
}