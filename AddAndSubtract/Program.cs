namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber);
            int diff = Subtract(sum, thirdNumber);

            Console.WriteLine(diff);
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}