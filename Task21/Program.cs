
using System;
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

Console.Clear(); 
Console.Write("Введите трёхзначное число: ");
int num = new Random().Next(100,1000);
string numS=num.ToString();
int second = Convert.ToInt32(numS[1].ToString());

Console.WriteLine(num);

Console.WriteLine("Вторая цифра числа = " + second);


