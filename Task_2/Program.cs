using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();

            int matrixHeight, matrixWidth;
            int[,] firstMatrix,secondMatrix,resultMatrix;

            Console.WriteLine("Введите размер матриц");
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

            //Установка размеров матриц
            firstMatrix = new int[matrixHeight, matrixWidth];
            secondMatrix = new int[matrixHeight, matrixWidth];
            resultMatrix = new int[matrixHeight, matrixWidth];

            //Подсчёты всех сумм и показ первой матрицы
            Console.WriteLine("Первая матрица: \n");
            for (int i = 0; i < matrixHeight; i++) 
            { 
                for (int j = 0;j < matrixWidth;j++)
                {
                    int firstValue = rand.Next(101);
                    int secondValue = rand.Next(101);

                    firstMatrix[i,j] = firstValue;
                    secondMatrix[i,j] = secondValue;

                    resultMatrix[i,j] = firstValue + secondValue;

                    Console.Write($"\t{firstMatrix[i,j]}");
                }
                Console.WriteLine();
            }

            //Показ второй матрицы
            Console.WriteLine("\nВторая матрица: \n");
            for (int i = 0;i < matrixHeight;i++)
            {
                for(int j = 0; j < matrixWidth;j++)
                {
                    Console.Write($"\t{secondMatrix[i,j]}");
                }
                Console.WriteLine();
            }

            //Показ третей матрицы
            Console.WriteLine("\nСумма двух матриц: \n");
            for (int i = 0; i < matrixHeight; i++)
            {
                for (int j = 0; j < matrixWidth; j++)
                {
                    Console.Write($"\t{resultMatrix[i, j]}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
