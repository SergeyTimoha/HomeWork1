/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
using System;
using static System.Console;

int[] a = new int[3];
int[] b = new int[3];
int result = 0;

for(int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0,50);
    WriteLine("a " + a[i]);
    b[i] = new Random().Next(0,50);
    WriteLine("b " + b[i]);
    result = result + (b[i] - a[i]) * (b[i] - a[i]);
}
WriteLine($"{Math.Sqrt(result):f2}");