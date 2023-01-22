//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());


if (number>5)
{
    Console.WriteLine("C выходным!");
}
else if (number<=5)
{
    Console.WriteLine("Опять работа...");
}