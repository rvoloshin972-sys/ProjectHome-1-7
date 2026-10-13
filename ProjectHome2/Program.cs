using System;
namespace ProjectHome2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[,] array = new int[5, 5]; 
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++) 
            { 
                for (int j = 0; j < array.GetLength(1); j++) 
                { 
                    array[i, j] = random.Next(-100, 101); 
                } 
            }

            Console.WriteLine("Двовимірний масив:"); 
            for (int i = 0; i < array.GetLength(0); i++) 
            { 
                for (int j = 0; j < array.GetLength(1); j++) 
                { 
                    Console.Write($"{array[i, j],5}"); 
                } 
                Console.WriteLine(); 
            }

            int min = array[0, 0]; 
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    min = Math.Min(min, array[i, j]); 
                    max = Math.Max(max, array[i, j]);
                }
            }

            int minPosition = 0; 
            int maxPosition = 0; 
            int position = 0;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    minPosition = array[i, j] == min 
                        ? position 
                        : minPosition;
                    maxPosition = array[i, j] == max 
                        ? position 
                        : maxPosition;
                    position++;
                }
            }

            int start = Math.Min(minPosition, maxPosition); 
            int end = Math.Max(minPosition, maxPosition);
            int sum = 0; 
            position = 0;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    sum += position > start && position < end 
                        ? array[i, j] 
                        : 0; 
                    position++;
                }
            }

            Console.WriteLine(); 
            Console.WriteLine($"Мінімальний елемент: {min}"); 
            Console.WriteLine($"Максимальний елемент: {max}"); 
            Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sum}"); 
            Console.ReadKey();
        }
    }
}
