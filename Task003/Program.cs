/*Написать программу, которая на вход принимает координаты двух точек и находит рассояние между ними в 2D пространстве
А (3,6); В (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.Write("Введите координату 1 точки по оси x: ");
double x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату 1 точки по оси y: ");
double y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату 2 точки по оси x: ");
double x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату 2 точки по оси x: ");
double y2 = int.Parse(Console.ReadLine());

double num1 = Math.Pow((x2 - x1), 2);
double num2 = Math.Pow((y2 - y1), 2);
double result = Math.Sqrt(num1 + num2);

Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2)}");

/*Console.Write("Введите координаты точки А: ");
double A = double.Parse(Console.ReadLine());
string A1 = Convert.ToString(A);
Console.Write("Введите координаты точки А: ");
double B = double.Parse(Console.ReadLine());
string B1 = Convert.ToString(B);

double AB = Math.Sqrt(Math.Pow(B1[0] - A1[1], 2) + Math.Pow(B1[0] - A1[1], 2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(AB, 2)}");*/