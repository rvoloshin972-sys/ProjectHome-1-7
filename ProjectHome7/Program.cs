using System;
namespace ProjectHome7
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть текст:");
            Console.WriteLine("Для завершення введення натисніть Enter на порожньому рядку:");

            string[] lines = new string[100]; 
            int lineCount = 0;

            string line = Console.ReadLine() ?? ""; 
            while (line != "") 
            {
                lines[lineCount] = line; 
                lineCount++; 
                line = Console.ReadLine() ?? "";
            }

            Console.Write("Неприпустиме слово: ");
            string badWord = (Console.ReadLine() ?? "").Trim
                (',', '.', '!', '?', ':', ';', '\'', '"');
            int count = 0;
            for (int i = 0; i < lineCount; i++)
            {
                string[] words = lines[i].Split(' ');
                for (int j = 0; j < words.Length; j++) 
                {
                    string cleanWord = words[j].Trim
                        (',', '.', '!', '?', ':', ';', '\'', '"');
                    bool found = cleanWord.Equals
                        (badWord, StringComparison.OrdinalIgnoreCase);
                    count += found ? 1 : 0;
                    string stars = new string('*', badWord.Length);
                    words[j] = found ? words[j].Replace(cleanWord, stars) : words[j];
                }
                lines[i] = string.Join(" ", words);
            }

            string result = string.Join("\n", lines, 0, lineCount);
            Console.WriteLine(); 
            Console.WriteLine("Результат роботи:"); 
            Console.WriteLine(result);
            Console.WriteLine(); 
            Console.WriteLine("Статистика: " + count + " заміни слова " + badWord + ".");
        }
    }
}
