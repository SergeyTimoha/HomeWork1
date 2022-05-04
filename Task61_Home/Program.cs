/*ВАРИАНТ 1: Задача 43: Напишите программу, которая найдёт точку пересечения двух:
 прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

Console.WriteLine("Введите точку b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"({x} , {y})");

/*ВАРИАНТ 2: 

Console.WriteLine("Введите четыре цифры координат через пробел: ");
double[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>double.Parse(x)).ToArray();
double b1 = arr[0];
double k1 = arr[1];
double b2 = arr[2];
double k2 = arr[3];
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"({x} , {y})");*/

