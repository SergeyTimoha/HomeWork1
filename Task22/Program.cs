
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear(); 
Console.Write("Введите любое число: ");
int num = new Random().Next(0,1000);
string numS=num.ToString();
Console.WriteLine(num);
if(num > 99)
{
    Console.WriteLine("Третья цифра заданного числа = " + numS[2]);
}
else
    Console.WriteLine("Третьего числа нет!");

