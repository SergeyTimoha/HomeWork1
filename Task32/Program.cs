/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет
, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
string num = new(Console.ReadLine());
bool pol = true;
Console.WriteLine(num);
for (int i = 0; i < num.Length; i++)
{
    if (num[i] != num[num.Length - i -1]) 
    {
        pol = false;
        break;
    }
}
if (pol)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}