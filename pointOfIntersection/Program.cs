//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.



Console.WriteLine("Введите через пробел значения переменных k1, b1, k2, b2");
string line = Console.ReadLine()!;
string[] parts = line.Split(' ');
double k1 = double.Parse(parts[0]);
double b1 = double.Parse(parts[1]);
double k2 = double.Parse(parts[2]);
double b2 = double.Parse(parts[3]);

if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    System.Console.WriteLine("Прямые паралелльны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"Прямые пересекаются в точке: ({Math.Round(x, 3)}; {Math.Round(y, 3)})");
}


