 
// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber (string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToDouble(Console.ReadLine());
}

double xa = ReadNumber("Введите координату первой точки по оси X "); // Console.WriteLine("Введите координату первой точки по оси X ");
double ya = ReadNumber("ведите координату первой точки по оси Y "); // Console.WriteLine("Введите координату первой точки по оси Y ");
double za = ReadNumber("Введите координату первой точки по оси Z "); // Console.WriteLine("Введите координату первой точки по оси Z ");

double xb = ReadNumber("Введите координату второй точки по оси X "); // Console.WriteLine("Введите координату второй точки по оси X ");
double yb = ReadNumber("Введите координату второй точки по оси Y "); // Console.WriteLine("Введите координату второй точки по оси Y ");
double zb = ReadNumber("Введите координату первой точки по оси Z "); // Console.WriteLine("Введите координату первой точки по оси Z ");

double S = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между двумя точками равно: {S}");
