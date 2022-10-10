/*
Задача 50. Напишите программу, 
которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/

internal class Program
{
    private static void Main(string[] args)
    {
        int GetNumber(string line)
        {
            Console.WriteLine(line);
            int number = int.Parse(Console.ReadLine() ?? "");
            return number;
        }

        int row = GetNumber("Задайте количество строк, двумерного массива: ");
        int column = GetNumber("Задайте количество столбцов, двумерного массива: ");

        Console.WriteLine();


        int[,] myArr = new int[row, column];

        Random ran = new Random();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                myArr[i, j] = ran.Next(1, 10);
                Console.Write("{0}\t", myArr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int num = GetNumber("Введите число: ");

        Console.WriteLine();

        int numExists = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (myArr[i, j] == num)
                {
                    numExists = 1;
                    Console.WriteLine($"Число {num} есть в массиве, на позиции: строка {i}, столбец {j}.");

                }
            }
        }
        if (numExists != 1)
            Console.WriteLine($"Числа {num} нет в массиве.");
    }
}