using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[,] garden = new int[dimentions[0], dimentions[1]];

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    garden[row, col] = 0;
                }
            }

            string[] coords = Console.ReadLine().Split(" ").ToArray();

            while (coords[0] != "Bloom")
            {
                int row = int.Parse(coords[0]);
                int column = int.Parse(coords[1]);

                if (row < 0 || row >= dimentions[0] 
                    || column < 0 || column >= dimentions[1])
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    for (int rows = 0; rows < dimentions[0]; rows++)
                    {
                        if (garden[rows, column] > 0)
                        {
                            garden[rows, column] += 1;
                        }
                        else
                        {
                            garden[rows, column] = 1;
                        }  
                    }

                    for (int cols = 0; cols < dimentions[1]; cols++)
                    {
                        if (cols == column)
                        {
                            continue;
                        }
                        if (garden[row, cols] > 0)
                        {
                            garden[row, cols] += 1;
                        }
                        else
                        {
                            garden[row, cols] = 1;
                        }
                    }
                }

                coords = Console.ReadLine().Split(" ").ToArray();
            }

            for (int row = 0; row < dimentions[0]; row++)
            {
                for (int col = 0; col < dimentions[1]; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
