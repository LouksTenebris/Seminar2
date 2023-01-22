//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = number.ToString().Length;

int MakeArray(int a, int b)
{
int result = -1;
    if (b < 3)
    {
        Console.WriteLine("Третьей цифры нет, держи");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}

Console.Write($"Введеное число: {number}, Третья цифра числа: {MakeArray(number, count)}");