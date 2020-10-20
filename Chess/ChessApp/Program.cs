using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chess Generator");

            Console.WriteLine("Input Horizontal Row: ");
            var horizontalRowLength = Console.ReadLine();

            Console.WriteLine("Input Vertical Row: ");
            var verticalRowLength = Console.ReadLine();

            int ver = int.Parse(verticalRowLength);
            int hor = int.Parse(horizontalRowLength);
            int remainingTiles;

            for (int h = 1; h <= hor; h++)
            {
                if (h % 2 == 0)
                { 
                    remainingTiles = 1;
                }
                else 
                { 
                    remainingTiles = 0;
                }
                for (int v = 1; v <= ver; v++)
                {
                    if (v % 2 == remainingTiles)
                    { 
                        Console.Write("▓▓");
                    }
                    else
                    { 
                        Console.Write("░░");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tada chess!");
        }
    }
}


