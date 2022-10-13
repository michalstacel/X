using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int.TryParse(Console.ReadLine(), out int input);
      
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (i == j || j == input - i - 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}