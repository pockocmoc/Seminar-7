/*
Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

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

        // Объявляем двумерный массив
        double[,] myArr = new double[row, column];

        Random ran = new Random();

        // Инициализируем данный массив
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                myArr[i, j] = ran.NextDouble() * ran.Next(-9, 10);
                Console.Write("{0,6:F2}", myArr[i, j]);
            }
            Console.WriteLine();
        }
    }
}