using System;
namespace ProjectHome6
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine() ?? "";
            char[] symbols = text.ToCharArray();
            bool newSentence = true;
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = newSentence && char.IsLetter(symbols[i])
                    ? char.ToUpper(symbols[i])
                    : symbols[i];
                newSentence = ".!?".Contains(symbols[i]) ||
                              (newSentence && !char.IsLetter(symbols[i]));
            }

            Console.WriteLine("Результат:");
            Console.WriteLine(new string(symbols));
        }
    }
}
