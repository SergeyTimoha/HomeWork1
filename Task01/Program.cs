using System;
using static System.Console;

WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());

if (number % 2 == 0)
{
    WriteLine("Чётное число");
}
else
{
    WriteLine("Нечётное число");
}