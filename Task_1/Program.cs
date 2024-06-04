using System;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();

            int matrixHeight, matrixWidth;
            int matrixSum = 0;
            int[,] matrix;

            Console.WriteLine("Введите размер матрицы");
            Console.WriteLine("Высота");
            string inputHeight = Console.ReadLine().Trim();
            Console.WriteLine("Ширина");
            string inputWidth = Console.ReadLine().Trim();

            //Проверка ввода
            while (true) 
            {
                if (int.TryParse(inputHeight, out matrixHeight) && int.TryParse(inputWidth, out matrixWidth))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Одно из значений не является цифрой, введите значения заново");

                    Console.WriteLine("Высота");
                    inputHeight = Console.ReadLine().Trim();
                    Console.WriteLine("Ширина");
                    inputWidth = Console.ReadLine().Trim();
                }
            }

            matrix = new int[matrixHeight, matrixWidth];

            //Горизонтальная сумма чисел матрицы
            for (int i = 0; i < matrixHeight; i++) 
            {
                int sumMatrixHorizontal = 0;

                for (int j = 0; j < matrixWidth; j++)
                {
                    matrix[i,j] = rand.Next(101);
                    Console.Write($"\t{matrix[i, j]}");

                    sumMatrixHorizontal += matrix[i, j];
                }
                Console.Write($" = {sumMatrixHorizontal}");
                matrixSum += sumMatrixHorizontal;
                Console.WriteLine("\n");
            }
            
            //Отступ с знаками равенства
            for(int i = 0; i < matrixWidth;i++)
            {
                Console.Write("\t=");
            }
            Console.WriteLine();

            //Вертикальная сумма чисел матрицы
            for (int i = 0;i < matrixWidth;i++)
            {
                int sumMatrixVertical = 0;
                for (int j = 0;j < matrixHeight;j++)
                {
                    sumMatrixVertical += matrix[j,i];
                }
                Console.Write($"\t{sumMatrixVertical}");
            }
            //Результат
            Console.WriteLine($"\n\nСумма всех цисел матрицы = {matrixSum}");
            Console.ReadKey();
        }
    }
}
