using System;
namespace ProjectHome1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] A = new int[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Введіть 5 елементів масиву A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine()!);
            }

            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * 20 - 10;
                }
            }

            Console.WriteLine("\nМасив A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n\nМасив B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]:F2}\t");
                }
                Console.WriteLine();
            }

            double max = A[0];
            double min = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                max = Math.Max(max, A[i]);
                min = Math.Min(min, A[i]);
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    max = Math.Max(max, B[i, j]);
                    min = Math.Min(min, B[i, j]);
                }
            }

            double sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                }
            }

            double product = 1;
            for (int i = 0; i < A.Length; i++)
            {
                product *= A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    product *= B[i, j];
                }
            }

            int evenSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                evenSum += A[i] * (1 - Math.Abs(A[i] % 2));
            }

            double oddColumnsSum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    oddColumnsSum += B[i, j] * (j % 2);
                }
            }
            Console.WriteLine("\nРезультати:");
            Console.WriteLine($"Загальний максимальний елемент: {max:F2}");
            Console.WriteLine($"Загальний мінімальний елемент: {min:F2}");
            Console.WriteLine($"Загальна сума всіх елементів: {sum:F2}");
            Console.WriteLine($"Загальний добуток всіх елементів: {product:F2}");
            Console.WriteLine($"Сума парних елементів масиву A: {evenSum}");
            Console.WriteLine($"Сума елементів непарних стовпців масиву B: {oddColumnsSum:F2}");

            Console.ReadKey();
        }
    }
}
