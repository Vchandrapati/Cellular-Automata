using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Map_Generation.Variables;

namespace Map_Generation
{
    public partial class GridMapGenerator : Form
    {
        public GridMapGenerator()
        {
            InitializeComponent();
        }
        List<int> terrain = new List<int>();
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MapWidth = 40;
            MapHeight = 40;
            CellHeight = CellWidth = 8;

            weightedList();
            int[,] generated = new int[MapWidth, MapHeight];
            PrintMap(Init(generated));
        }
        private void PrintMap(int[,] generated)
        {
            Bitmap Map = new Bitmap(MapWidth * CellWidth, MapHeight * CellHeight);

            using (var pMap = Graphics.FromImage(Map))
            {
                pMap.Clear(Color.Black);
                for (var x = 0; x < MapHeight; x++)
                    for (var y = 0; y < MapWidth; y++) 
                        if (generated[x, y] == 0)
                            pMap.FillRectangle(Brushes.WhiteSmoke, x * CellWidth, y * CellHeight, CellWidth, CellHeight);
                         else if (generated[x, y] == 1)
                            pMap.FillRectangle(Brushes.GreenYellow, x * CellWidth, y * CellHeight, CellWidth, CellHeight);
                        else if (generated[x, y] == 2)
                            pMap.FillRectangle(Brushes.DeepSkyBlue, x * CellWidth, y * CellHeight, CellWidth, CellHeight);
                        else if (generated[x, y] == 3)
                            pMap.FillRectangle(Brushes.Green, x * CellWidth, y * CellHeight, CellWidth, CellHeight);
            }
            
            pbMap.Width = Map.Width;
            pbMap.Height = Map.Height;
            pbMap.Image = Map;
        }
        private int[,] Init(int[,] generated)
        {
            Random getType = new Random();
            for (int x = 0; x < MapWidth; x++)
                for (int y = 0; y < MapHeight; y++)
                {
                    int type = terrain[getType.Next(terrain.Count)];
                    if (type == 0)
                        generated[x, y] = 0;
                    else if (type == 1)
                        generated[x, y] = 1;
                    else if (type == 2)
                        generated[x, y] = 2;
                    else if (type == 3)
                        generated[x, y] = 3;
                }

            return generated;
        }
        private void weightedList()
        {
            for (int i = 0; i < (int)Terrain.Snow; i++)
                terrain.Add(0);
            for (int i = 0; i < (int)Terrain.Grassland; i++)
                terrain.Add(1);
            for (int i = 0; i < (int)Terrain.Lake; i++)
                terrain.Add(2);
            for (int i = 0; i < (int)Terrain.Forest; i++)
                terrain.Add(3);
        }
        public enum Terrain
        {
            Snow = 2,
            Grassland = 73,
            Forest = 20,
            Lake = 5,
        }
    }
}
