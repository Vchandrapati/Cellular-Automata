using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cellular_Automata_v2;

namespace Map_Generation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btnCell_Click(object sender, EventArgs e)
        {
            CellGenerator fm = new CellGenerator();
            this.Hide();
            fm.Show();
        }
        private void btnPnoise_Click(object sender, EventArgs e)
        {
            PnoiseMapGenerator pmg = new PnoiseMapGenerator();
            this.Hide();
            pmg.Show();
        }
        private void btnVoronoi_Click(object sender, EventArgs e)
        {
            VoronoiGenerator vg = new VoronoiGenerator();
            this.Hide();
            vg.Show();
        }
        private void btnGeneration_Click(object sender, EventArgs e)
        {
            DungeonGenerator dg = new DungeonGenerator();
            this.Hide();
            dg.Show();
        }
        private void btnTunnel_Click(object sender, EventArgs e)
        {
            TunnelGenerator tg = new TunnelGenerator();
            this.Hide();
            tg.Show();
        }
        private void btnGrid_Click(object sender, EventArgs e)
        {
            GridMapGenerator gmg = new GridMapGenerator();
            this.Hide();
            gmg.Show();
        }
    }
}
