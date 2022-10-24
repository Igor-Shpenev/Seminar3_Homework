// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Формула: AB=√(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double ab = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return ab;
}


Console.Write("Введите координату xa: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату za: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату xb: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb: ");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb: ");
int num6 = Convert.ToInt32(Console.ReadLine());

double result = Distance(num1, num2, num3, num4, num5, num6);
Console.WriteLine($"Расстояние между точкой A с координатами ({num1}, {num2}, {num3}) и точкой B с координатами ({num4}, {num5}, {num6}) равно {result}");
