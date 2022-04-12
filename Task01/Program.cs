using System;
using static System.Console;

WriteLine("Введите число");
int number = int.Parse(ReadLine());
if (number % 2 == 0)
{
    WriteLine("Чётное число");
}
else
{
    WriteLine("Нечётное число");
}