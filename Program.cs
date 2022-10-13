using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int input);
            Console.WriteLine("Input a number: ");

            for (int i = 0; i < input; i++)
            {

                for (int j = 0; j < input; j++)
                {
                    if (i == j || j == input - i - 1)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}