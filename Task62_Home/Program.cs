/*ВАРИАНТ 1: Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько:
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
 
 /*ВАРИАНТ 2: Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
 чисел больше 0 ввёл пользователь.*/

/*int countPlus = 0;
int M;
Console.WriteLine("Укажите сколько ввести чисел: ");
M = Convert.ToInt32(Console.ReadLine());
 int[] mas = new int[M];

    for (int i = 0; i < M; i++)

    {

        Console.WriteLine("Введите {0}-й элемент", i + 1);

        mas[i] = int.Parse(Console.ReadLine());

    }
    for (int i = 0; i < M; i++)

    {

        if (mas[i] > 0)

        {

            countPlus++;

        }

    }
    
    Console.WriteLine();

    Console.WriteLine("Количество чисел больше нуля = " + countPlus);*/