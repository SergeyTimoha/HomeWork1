/*using System;
using System.Linq;

Console.Clear();
int[] numbers = genetateArray(10, 100, 999);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Число чётных элементов в массиве: {countEvens(numbers)}.");

int[] genetateArray(int size, int mixValue, int maxValue)
{
    int[] generatedArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return generatedArray;
}

int countEvens(int[] numArray)
{
    int counter = numArray.Where(x => x % 2 == 0).Count();
    return counter;
}*/

/*using System;
using System.Linq;

Console.Clear();
int[] numbers = genetateArray(10, 0, 99);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Сумма элементов с нечётным индексом: {sumOddIndex(numbers)}.");

int[] genetateArray(int size, int mixValue, int maxValue)
{
    int[] generatedArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return generatedArray;
}

int sumOddIndex(int[] numArray)
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
}*/

using System;
using System.Linq;

Console.Clear();
int[] numbers = genetateArray(10, 0, 99);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine($"Разность максимального и минимального элементов массива: {findMax(numbers) - findMin(numbers)}.");

int[] genetateArray(int size, int mixValue, int maxValue)
{
    int[] generatedArray = new int[size].Select(x => new Random().Next(mixValue, maxValue + 1)).ToArray();
    return generatedArray;
}

int findMin(int[] numArr)
{
    int min = numArr.Min();
    return min;
}

int findMax(int[] numArray)
{
    int max = numArray.Max();
    return max;
}