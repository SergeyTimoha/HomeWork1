/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

using System;
using System.Linq;

Console.Clear();
int[] numbers = FillArray(10, 0, 99);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Сумма элементов с нечётным индексом: {sumOddNum(numbers)}.");

int[] FillArray(int size, int mixValue, int maxValue)
{
    int[] getArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return getArray;
}

int sumOddNum(int[] numArray)
{
    int sum = 0;
    for (int i = 0; i < numArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += numArray[i];
        }
    }
    return sum;
}