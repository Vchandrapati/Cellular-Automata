using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static Map_Generation.Variables;

namespace Map_Generation
{
    public partial class TunnelGenerator : Form
    {
        public TunnelGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MapWidth = 40;
            MapHeight = 40;
            CellWidth = CellHeight = 8;

            var Map = new Bitmap(MapWidth * CellWidth, MapHeight * CellHeight);
            using (var pMap = Graphics.FromImage(Map))
            {
                pMap.Clear(Color.Black);
                for (var y = 0; y < MapHeight; y++)
                for (var x = 0; x < MapWidth; x++)
                    pMap.FillRectangle(Brushes.Black, x * CellWidth, y * CellHeight, CellWidth, CellHeight);

                Random lineInit = new Random();


                Pen path = new Pen(Color.White, CellHeight / 2);

                for (int i = 0; i < 10; i++)
                {
                    int x1 = lineInit.Next(0, Map.Width);
                    int y1 = lineInit.Next(0, Map.Height);
                    int x2 = lineInit.Next(0, Map.Width);
                    int y2 = lineInit.Next(0, Map.Height);


                    PointF start = new Point(x1, y1);
                    PointF end = new Point(x2, y2);

                    pMap.DrawLine(path, Map.Width / 2, Map.Height / 2, x1, y1);
                    pMap.DrawLine(path, Map.Width / 2, Map.Height / 2, x2, y2);
                    pMap.DrawLine(path, start, end);
                }
            }

            pbMap.Image = Map;
        }
        private void Init()
        {

        }
    }
}
