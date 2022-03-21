using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static Map_Generation.Spawn;
using static Map_Generation.Variables;

namespace Map_Generation
{
    public partial class CellGenerator : Form
    {
        public CellGenerator()
        {
            InitializeComponent();
            Text = "Cellular Map Generator";
            Startup();

            lblCS.Text = $@"Cell Size: {tbcs.Value}";
            lblMW.Text = $@"Map Width: {tbmw.Value}";
            lblMH.Text = $@"Map Height: {tbmh.Value}";
            lblCSC.Text = $@"Cell Survival Chance: {tbcss.Value}%";
        }

        [Localizable(false)]
        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            CellWidth = CellHeight = tbcs.Value;
            MapWidth = tbmw.Value;
            MapHeight = tbmh.Value;
            SurvivalChance = (100 - Convert.ToDecimal(tbcss.Value)) / 100;

            var generated = new int[MapWidth, MapHeight];

            if (cbe.Checked && cbt.Checked)
                PrintMap(PlaceEnemies(PlaceTreasure(Processing(Init(generated)))));
            else if (cbt.Checked)
                PrintMap(PlaceTreasure(Processing(Init(generated))));
            else if (cbe.Checked)
                PrintMap(PlaceEnemies(Processing(Init(generated))));
            else
                PrintMap(Processing(Init(generated)));

            Text = "Cellular Map Generator";
        }

        private void tbValue_Changed(object sender, EventArgs e)
        {
            lblCS.Text = $@"Cell Size: {tbcs.Value}";
            lblMW.Text = $@"Map Width: {tbmw.Value}";
            lblMH.Text = $@"Map Height: {tbmh.Value}";
            lblCSC.Text = $@"Cell Survival Chance: {tbcss.Value}%";
        }

        private void PrintMap(int[,] generated)
        {
            Status("Status: Initializing Printing Algorithm");
            var cellMap = new Bitmap(MapWidth * CellWidth, MapHeight * CellHeight);
            using (var pMap = Graphics.FromImage(cellMap))
            {
                pMap.Clear(Color.Black);
                for (var y = 0; y < MapHeight; y++)
                for (var x = 0; x < MapWidth; x++)
                    pMap.FillRectangle(
                        generated[x, y] == 1 ? Brushes.Black :
                        generated[x, y] == 0 ? Brushes.White :
                        generated[x, y] == 2 ? Brushes.Gold : Brushes.Red, x * CellWidth, y * CellHeight, CellWidth,
                        CellHeight);
            }

            Status("Status: Printing Map");

            pbMap.Image = cellMap;
        }

        private int[,] Init(int[,] terrain)
        {
            Status("Status: Initializing Cell Map Generation Algorithm");

            var cell = new Random();
            Status("Status: Creating Cell Map");
            for (var x = 0; x < MapWidth; x++)
            for (var y = 0; y < MapHeight; y++)
                if (cell.NextDouble() < Convert.ToDouble(SurvivalChance))
                    terrain[x, y] = 1;
                else
                    terrain[x, y] = 0;


            Status("Status: Completed Generating Cell Map");
            return terrain;
        }

        public static int CountNeighbours(int[,] generated, int x, int y)
        {
            var count = 0;

            for (var i = -1; i < 2; i++)
            for (var j = -1; j < 2; j++)
            {
                var nx = x + i;
                var ny = y + j;
                if (nx < 0 || ny < 0 || nx >= MapWidth || ny >= MapHeight)
                    count++;
                else if (generated[nx, ny] == 1)
                    count++;
            }

            return count;
        }

        private int[,] Processing(int[,] generated)
        {
            var count = 0;
            double j;
            var _ = (double) SurvivalChance > 0.61 && (double) SurvivalChance < 0.74 ? j = 10 :
                (double) SurvivalChance > 0.49 && (double) SurvivalChance < 0.61 ? j = 1000 : j = 5;

            Status("Status: Initializing Smoothing Algorithm");
            Status($"Status: Applying Cave Smoothing {j} Times");
            Status("Status: Calculating Live Neighbours For Each Cell");
            Status("Status: Applying Rule-sets");
            for (var i = 0; i < j; i++)
            {
                count++;
                Text = $"Iteration {count} out of {j}";
                for (var x = 0; x < MapWidth; x++)
                for (var y = 0; y < MapHeight; y++)
                {
                    var neighbours = CountNeighbours(generated, x, y);

                    if (generated[x, y] == 1)
                    {
                        if (neighbours < deathRule)
                            generated[x, y] = 0;
                        else
                            generated[x, y] = 1;
                    }
                    else
                    {
                        if (neighbours > birthRule)
                            generated[x, y] = 1;

                        else
                            generated[x, y] = 0;
                    }
                }
            }

            Status("Status: Finished Smoothing");
            return generated;
        }

        private void btnLoadRS_Click(object sender, EventArgs e)
        {
            tbcss.Value = 67;
            tbcs.Value = 8;
            tbmh.Value = 50;
            tbmw.Value = 50;

            lblCS.Text = $@"Cell Size: {tbcs.Value}";
            lblMW.Text = $@"Map Width: {tbmw.Value}";
            lblMH.Text = $@"Map Height: {tbmh.Value}";
            lblCSC.Text = $@"Cell Survival Chance: {tbcss.Value}%";
        }

        private void Status(string status)
        {
            Text = status;
            Thread.Sleep(0);
        }

        private void Startup()
        {
            var cs = new ToolTip();
            var mh = new ToolTip();
            var mw = new ToolTip();
            var csc = new ToolTip();
            cs.SetToolTip(lblCS, "This represents the size of each cell when displaying the map, base value is 5");
            cs.SetToolTip(tbcs, "This represents the size of each cell when displaying the map, base value is 5");
            mh.SetToolTip(lblMH, "The height of the map, base value is 50");
            mh.SetToolTip(tbmh, "The height of the map, base value is 50");
            mw.SetToolTip(lblMW, "The width of the map, base value is 50");
            mw.SetToolTip(tbmw, "The width of the map, base value is 50");
            csc.SetToolTip(lblCSC,
                "This affects the size of the caves, \n warning: going to low of the cell survival chance can result in small closed off caves, conversely going to high will result in a single large cave");
            csc.SetToolTip(tbcss,
                "This affects the size of the caves,  \n Warning: going to low of the cell survival chance can result in small closed off caves, conversely going to high will result in a single large cave");


            tbcs.Minimum = 5;
            tbcs.Maximum = 25;
            tbmh.Minimum = 50;
            tbmh.Maximum = 100;
            tbmw.Minimum = 50;
            tbmw.Maximum = 100;
            tbcss.Minimum = 50;
            tbcss.Maximum = 100;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var mm = new MainMenu();
            Close();
            mm.Show();
        }
    }
}