/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
 чисел больше 0 ввёл пользователь.
 0, 7, 8, -2, -2 -> 2
 1, -7, 567, 89, 223 -> 3*/

using System;
using System.Linq;
Console.Clear();
Console.Write("Введите количество чисел M: ");
int size = int.Parse(Console.ReadLine());
int[] N = new int[size].Select(x=>new Random().Next(-1000,1000)).ToArray();
Console.WriteLine(String.Join(" ", N ));
int M = N.Where(x=>x>0).Count();
Console.Write($"Сколько чисел больше 0? -> {M} " ); 
 