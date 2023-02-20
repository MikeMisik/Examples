// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = V((xb - xa)^2 + (yb - ya)^2)

Console.WriteLine("Введите координату первой точки по оси X ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату первой точки по оси Y ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси X ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси Y ");
double yb = Convert.ToDouble(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// double S2 = Math.Pow(yb - ya, 2);
Console.WriteLine($"Расстояние между двумя точками равно: {S}");



