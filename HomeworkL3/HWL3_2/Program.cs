// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{
    System.Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

int Ax = Promt("Введите координату точки A по оси x");
int Ay = Promt("Введите координату точки A по оси y");
int Az = Promt("Введите координату точки A по оси z");
int Bx = Promt("Введите координату точки B по оси x");
int By = Promt("Введите координату точки B по оси y");
int Bz = Promt("Введите координату точки B по оси z");
double distanceAB = GetDistance(Ax, Ay, Az, Bx, By, Bz);
System.Console.WriteLine($"Расстояние между точками A и B в 3D пространстве равно {distanceAB:f2}");