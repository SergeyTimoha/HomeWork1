
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающу
ю день недели, и проверяет, является ли этот день выходным.*/
Console.Clear(); 
Console.Write("Введите число: ");
int num = new Random().Next(1,8);
Console.WriteLine(num);
if(num > 5)
{
    Console.WriteLine("Да, выходной = " + num);
}
else
    Console.WriteLine("Нет, идём на работу");
