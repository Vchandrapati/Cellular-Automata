using Cellular_Automata_v2;
using static Map_Generation.Variables;

namespace Map_Generation
{
    public class Spawn : CellGenerator
    {
        public static int[,] PlaceEnemies(int[,] generated)
        {
            int enemyLimit = 5;
            for (int i = 0; i < 100; i++)
                for (int x = 0; x < MapWidth; x++)
                    for (int y = 0; y < MapHeight; y++)
                    {
                        if (generated[x, y] == 0)
                        {
                            int neighbours = CountNeighbours(generated, x, y);
                            if (neighbours >= enemyLimit)
                                generated[x, y] = 3;
                        }
                    }

            return generated;
        }
        public static int[,] PlaceTreasure(int[,] generated)
        {
            int treasureLimit = 5;
            for (int i = 0; i < 100; i++)
                for (int x = 0; x < MapWidth; x++)
                    for (int y = 0; y < MapWidth; y++)
                    {
                        if (generated[x, y] == 0)
                        {
                            int neighbours = CountNeighbours(generated, x, y);
                            if (neighbours >= treasureLimit)
                                generated[x, y] = 2;

                        }
                    }

            return generated;
        }
    }
}

