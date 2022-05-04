
using System;
using System.Linq;
Console.Clear();

//int[] array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
//int[] array1 = array.Select(x=>x*-1).ToArray();
Console.WriteLine("Введите количество чисел");
//int size = int.Parse(Console.ReadLine());
//int[] array2 = new int[size].Select(x=>new Random().Next(-100,100)).ToArray();
//int M = new int[10].Select(x=>new Random().Next(-100,100)).Where(x=>x>=0&&x<=100).Count();
int[] M = new int[10].Select(x=>new Random().Next(-100,100)).Where(x=>x>=0&&x<=100).ToArray();
//int[] M =  array2.Where(x=>x>0&&x<=100).Count();
//int[] array2 = new int[size].Select(x=>new Random().Next(-100,100)).ToArray();
//Console.WriteLine(String.Join(" ", array)); 
//Console.WriteLine(String.Join(" ", array1)); 
//Console.WriteLine(String.Join(" ", array2)); 
Console.WriteLine(String.Join(" ", M));
