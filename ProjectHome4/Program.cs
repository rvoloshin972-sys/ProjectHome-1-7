using System;
namespace ProjectHome4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random random = new Random();
            Console.Write("Введіть кількість рядків матриць: "); 
            int rows = int.Parse(Console.ReadLine()!);

            Console.Write("Введіть кількість стовпців матриць: "); 
            int columns = int.Parse(Console.ReadLine()!);

            int[,] matrix1 = new int[rows, columns]; 
            int[,] matrix2 = new int[rows, columns];

            for (int i = 0; i < rows; i++) 
            { 
                for (int j = 0; j < columns; j++) 
                { 
                    matrix1[i, j] = random.Next(1, 10); 
                } 
            }
            for (int i = 0; i < rows; i++) 
            { 
                for (int j = 0; j < columns; j++) 
                { 
                    matrix2[i, j] = random.Next(1, 10); 
                } 
            }
            Console.WriteLine("\nПерша матриця:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nДруга матриця:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.Write("\nВведіть число для множення першої матриці: "); 
            int number = int.Parse(Console.ReadLine()!);
            int[,] result1 = new int[rows, columns];
            for (int i = 0; i < rows; i++) 
            { 
                for (int j = 0; j < columns; j++) 
                {
                    result1[i, j] = matrix1[i, j] * number; 
                } 
            }

            Console.WriteLine("\nМноження матриці на число:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write(result1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] result2 = new int[rows, columns]; 
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                { 
                    result2[i, j] = matrix1[i, j] + matrix2[i, j]; 
                }
            }
            
            Console.WriteLine("\nДодавання матриць:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                { 
                    Console.Write(result2[i, j] + "\t"); 
                }
                Console.WriteLine();
            }

            int[,] result3 = new int[rows, columns]; 
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    result3[i, j] = 0; 
                    for (int k = 0; k < columns; k++) 
                    {
                        result3[i, j] = result3[i, j] + matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("\nДобуток матриць:");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write(result3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
