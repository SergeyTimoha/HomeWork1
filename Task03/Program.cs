using System;
using static System.Console;


WriteLine("Введите первое число");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int b = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число");
int c = Convert.ToInt32(ReadLine());

if (a > b & a > c)
{
    WriteLine("Первое число max = " + a );
}
else
{
    if (b > c)
    {
        WriteLine("Второе число max = " + b );
    }
    else
    {

        WriteLine("Третье число max = " + c );
    }
}
