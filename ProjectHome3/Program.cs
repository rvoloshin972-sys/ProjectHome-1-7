using System;
using System.Text;
namespace ProjectHome3
{
    internal class Program
    {
        static string Encrypt(string text, int shift)
        {
            return Transform(text, shift);
        }

        static string Decrypt(string text, int shift)
        {
            return Transform(text, -shift);
        }

        static string Transform(string text, int shift)
        {
            string english = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string ukrainian = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

            StringBuilder result = new StringBuilder();
            foreach (char symbol in text)
            {
                char upper = char.ToUpper(symbol);
                string alphabet = english.Contains(upper)
                    ? english
                    : ukrainian;
                int index = alphabet.IndexOf(upper);
                int length = alphabet.Length;
                int normalizedShift = ((shift % length) + length) % length;
                int newIndex = (index + normalizedShift) % length;
                result.Append
                    (
                    index < 0
                        ? symbol
                        : char.IsUpper(symbol)
                            ? alphabet[newIndex]
                            : char.ToLower(alphabet[newIndex])
                    );
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string text = Console.ReadLine() ?? "";

            Console.Write("Введіть величину зсуву: ");
            int shift = int.Parse(Console.ReadLine() ?? "3");

            string encrypted = Encrypt(text, shift);
            string decrypted = Decrypt(encrypted, shift);
            Console.WriteLine("\nЗашифрований текст: " + encrypted);
            Console.WriteLine("Розшифрований текст: " + decrypted);
        }
    }
}
