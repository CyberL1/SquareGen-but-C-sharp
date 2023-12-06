using System;

namespace SquareGen_but_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide height");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height < 1)
            {
                Console.WriteLine("Height cannot be negative or zero");
            }

            Console.WriteLine("Provide width");
            int width = Convert.ToInt32(Console.ReadLine());

            if (width < 1)
            {
                Console.WriteLine("Width cannot be negative or zero");
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}