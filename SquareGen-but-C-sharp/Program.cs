using System;

namespace SquareGen_but_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide height");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Provide width");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}