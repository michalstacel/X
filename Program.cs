using System.Globalization;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Input a number: ");
            int.TryParse(Console.ReadLine(), out int input);
      
            for (int i = 0; i < input; i++)
            {
=======
            int.TryParse(Console.ReadLine(), out int input);
            Console.WriteLine("Input a number: ");

            for (int i = 0; i < input; i++)
            {

>>>>>>> 46563db5c7bb43b2d54fbd961c0e808d6aa83c7c
                for (int j = 0; j < input; j++)
                {
                    if (i == j || j == input - i - 1)
                    {
<<<<<<< HEAD
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("  ");
=======
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
>>>>>>> 46563db5c7bb43b2d54fbd961c0e808d6aa83c7c
                    }
                }
                Console.WriteLine();
            }
        }
    }
}