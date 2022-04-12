using System;
using static System.Console;


WriteLine("Введите первое число");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число");
int с = Convert.ToInt32(ReadLine());
int max = a;
if (max < b)
{
    max = b;
    WriteLine(max);
}
if (max < c);
{
    WriteLine(max);
    max = c;
}
WriteLine(max);