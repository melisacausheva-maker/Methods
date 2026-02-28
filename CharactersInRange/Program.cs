namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            char start = first;
            char end = second;

            if (second < first)
            {
                start = second;
                end = first;
            }

            PrintCharactersInRange(start, end);
        }

        static void PrintCharactersInRange(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();
        }
    }
}