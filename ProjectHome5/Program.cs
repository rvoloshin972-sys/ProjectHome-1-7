using System;
namespace ProjectHome5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть арифметичний вираз"); 
            Console.WriteLine("Дозволені операції: + та -"); 
            Console.Write("Приклад: 10+5-3+8: ");

            string expression = Console.ReadLine()!; 
            string[] numbers = expression.Split(new char[] { '+', '-' }); 
            int result = int.Parse(numbers[0]); 
            int numberIndex = 1;

            for (int i = 0; i < expression.Length; i++) 
            {
                char operation = expression[i]; 
                string operationText = operation.ToString();
                string[] operationParts = expression.Split
                    (new char[] { '+', '-' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                if (operationText == "+" || operationText == "-") 
                {
                    int number = int.Parse(operationParts[numberIndex]); 
                    result += (operation == '+' ? number : -number); 
                    numberIndex++;
                }
            }

            Console.WriteLine("Результат: " + result); 
            Console.ReadKey();
        }
    }
}
