/*
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.

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



        double[] sum = new double[column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                sum[j] += myArr[i, j];
            }
            Console.WriteLine();
        }


        foreach (double elem in sum)
        {

            Console.WriteLine(Math.Round(elem / row, 2));

        }
    }
}