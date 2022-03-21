using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Transactions;

namespace Cellular_Automata
{
class Program
    {
        public static dynamic mapWidth { get; set; }
        public static dynamic mapHeight { get; set; }
        public static dynamic percentWalls { get; set; }
        public static dynamic survivalChance { get; set; }
        static void Main(string[] args)
        {
            bool input = false;

            Console.WriteLine("Would u like to use the standard generation type or a custom generation type");
            while (!input)
            {
                if (Console.ReadLine().ToLower() == "standard")
                {
                    mapWidth = mapHeight = 40;
                    percentWalls = 30;
                    survivalChance = 0.45;
                    input = true;
                }
                else if (Console.ReadLine().ToLower() == "custom")
                {
                    Console.WriteLine("Enter the width of the map:");
                    mapWidth = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the height of the map:");
                    mapHeight = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the percentage of walls you would like:");
                    percentWalls = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter cell survival chance:");
                    survivalChance = Convert.ToDecimal(Console.ReadLine()) / 100;
                    input = true;
                }
                else
                {
                    Console.WriteLine("Please write standard or custom");
                }
            }

            int[,] map = new int[mapWidth, mapHeight];
            int[,] generated = init(map);

            PrintMap(generated);    
            countNeighbours(generated, 3, 2);

        }

        private static void PrintMap(int[,] generated)
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                    Console.Write($"{generated[i, j]} ");

                Console.WriteLine();
            }
        }

        private static int[,] init(int[,] terrain)
        {
            Random cell = new Random();
            for (int x = 0; x < mapWidth; x++)
                for (int y = 0; y < mapHeight; y++)
                    if (cell.Next(0, 2) < survivalChance)
                        terrain[x, y] = 1;

            return terrain;
        }     

        private static void countNeighbours(int[,] terrain, int x, int y)
        {
            int count = 0;
            for (int i = 1; i < mapWidth; i++)
            {
                for (int j = 1; j < mapHeight; j++)
                {
                    if (terrain[i - 1, j] == 1)
                        count++;
                    if (terrain[i + 1, j] == 1)
                        count++;
                    if (terrain[i, j - 1] == 1)
                        count++;
                    if (terrain[i + 1, j - 1] == 1)
                        count++;
                    if (terrain[i + 1, j + 1] == 1)
                        count++;
                    if (terrain[i - 1, j - 1] == 1)
                        count++;
                    if (terrain[i - 1, j + 1] == 1)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

