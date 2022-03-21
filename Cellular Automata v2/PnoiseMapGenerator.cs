using System;
using System.Drawing;
using System.Windows.Forms;
using static Map_Generation.Variables;

namespace Map_Generation
{
    public partial class PnoiseMapGenerator : Form
    {
        public PnoiseMapGenerator()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CellHeight = 8;
            CellWidth = 8;
            MapWidth = 80;
            MapHeight = 80;
            double[,] noise_map = new double[MapWidth, MapHeight];
            TranslateNoise(InitWhiteNoise(noise_map));
        }

        private void TranslateNoise(double[,] noise_map)
        {
            Bitmap noiseMap = new Bitmap(MapWidth * CellWidth, MapHeight * CellHeight);
            using (Graphics pMap = Graphics.FromImage(noiseMap))
            {
                pMap.Clear(Color.Black);
                for (int y = 0; y < MapHeight; y++)
                {
                    for (int x = 0; x < MapWidth; x++)
                    {
                        pMap.FillRectangle(
                            noise_map[x, y] == 0 ? Brushes.White :
                            noise_map[x, y] == 1 ? Brushes.WhiteSmoke :
                            noise_map[x, y] == 2 ? Brushes.Gainsboro :
                            noise_map[x, y] == 3 ? Brushes.LightGray :
                            noise_map[x, y] == 4 ? Brushes.Silver :
                            noise_map[x, y] == 5 ? Brushes.Gray :
                            noise_map[x, y] == 6 ? Brushes.DarkGray :
                            noise_map[x, y] == 7 ? Brushes.LightSlateGray :
                            noise_map[x, y] == 8 ? Brushes.SlateGray :
                            noise_map[x, y] == 9 ? Brushes.DimGray : Brushes.Black, x * CellWidth, y * CellHeight,
                            CellWidth, CellHeight);
                    }
                }
            }

            pbMap.Image = noiseMap;
        }
        private double[,] InitWhiteNoise(double[,] noise_map)
        {
            Random noise = new Random();
            for (int x = 0; x < MapWidth; x++)
                for (int y = 0; y < MapHeight; y++)
                    noise_map[x, y] = noise.Next(0, 11);

            return noise_map;
        }
    }
}
