//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Пишите только трёх значные числа. Введите число: ");
int number = int.Parse(Console.ReadLine());
int second_number = (number%100/10);

System.Console.WriteLine($"Введеное число: {number}, Вторая цифра числа: {second_number}");
