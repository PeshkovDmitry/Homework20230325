// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
// Значения k1, b1, k2 и b2 задаются пользователем

void Find(double kk1, double bb1, double kk2, double bb2) {
    double x = (bb2 - bb1)/(kk1 - kk2);
    double y = kk1 * x + bb1; 
    Console.WriteLine($"({Math.Round(x,2)};{Math.Round(y,2)})"); 
}

Console.Clear(); 
double k1, k2, b1, b2;
Console.Write("Введите k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
Find(k1, b1, k2, b2);