using System;
using static System.Console;


Write("Введите первое число: ");
int N = Convert.ToInt32(ReadLine());

int  C = 2;
while (C < N)
{
    WriteLine(C);
    C = C + 2;
}