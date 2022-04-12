using System;
using static System.Console;


WriteLine("Введите первое число");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(ReadLine());
int  max, min;
if (a > b)
{
   max = a;
   min = b;
   WriteLine("Первое число max = " + a  );
   WriteLine("Второе число min = " + b  );

}
else
{
    max = b;
    min = a;
    WriteLine("Второе число max = " + b);
    WriteLine("Первое число min = " + a  );

}

