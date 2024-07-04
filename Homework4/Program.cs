using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с матрицами");
            Console.WriteLine("\t\t\t===================================");
            Console.WriteLine("\t\t\t\tВыполнил:Агаджан Аннамураов");
            Console.WriteLine("\t\t\t\tTeach Me Skills");
            Console.WriteLine("\t\t\t===================================");

            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

          
            int[,] matrix = new int[rows, cols];

           
            Console.WriteLine("Заполните матрицу элементами:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nМатрица:");
            PrintMatrix(matrix);

            
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Найти количество положительных/отрицательных чисел");
                Console.WriteLine("2. Выход");
                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CountPositiveNegative(matrix);
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        static void CountPositiveNegative(int[,] matrix)
        {
            int positive = 0, negative = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                        positive++;
                    else if (matrix[i, j] < 0)
                        negative++;
                }
            }
            Console.WriteLine($"Количество положительных чисел: {positive}");
            Console.WriteLine($"Количество отрицательных чисел: {negative}");
        }
    }
}