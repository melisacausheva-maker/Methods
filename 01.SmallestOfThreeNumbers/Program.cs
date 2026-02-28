namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestNum = GetSmallestNum(firstNum, secondNum, thirdNum);

            Console.WriteLine(smallestNum);
        }

        static int GetSmallestNum(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}