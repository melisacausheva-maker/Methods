using System.Runtime.InteropServices;

namespace _04.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int output = GetVowel(text);
            Console.WriteLine(output);
        }

        static int GetVowel(string text)
        {
            int counter = 0;
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (letter == 'a' ||
                    letter == 'u' ||
                    letter == 'e' ||
                    letter == 'o' ||
                    letter == 'y' ||
                    letter == 'i')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}