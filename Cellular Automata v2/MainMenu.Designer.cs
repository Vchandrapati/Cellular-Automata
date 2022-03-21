namespace Map_Generation
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCell = new System.Windows.Forms.Button();
            this.btnPnoise = new System.Windows.Forms.Button();
            this.btnVoronoi = new System.Windows.Forms.Button();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.btnTunnel = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCell
            // 
            this.btnCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCell.Location = new System.Drawing.Point(25, 83);
            this.btnCell.Name = "btnCell";
            this.btnCell.Size = new System.Drawing.Size(189, 80);
            this.btnCell.TabIndex = 0;
            this.btnCell.Text = "Cellular Map Generation";
            this.btnCell.UseVisualStyleBackColor = true;
            this.btnCell.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnPnoise
            // 
            this.btnPnoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPnoise.Location = new System.Drawing.Point(220, 83);
            this.btnPnoise.Name = "btnPnoise";
            this.btnPnoise.Size = new System.Drawing.Size(189, 80);
            this.btnPnoise.TabIndex = 1;
            this.btnPnoise.Text = "Perlin Noise Map Generation";
            this.btnPnoise.UseVisualStyleBackColor = true;
            this.btnPnoise.Click += new System.EventHandler(this.btnPnoise_Click);
            // 
            // btnVoronoi
            // 
            this.btnVoronoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoronoi.Location = new System.Drawing.Point(25, 169);
            this.btnVoronoi.Name = "btnVoronoi";
            this.btnVoronoi.Size = new System.Drawing.Size(189, 80);
            this.btnVoronoi.TabIndex = 2;
            this.btnVoronoi.Text = "Voronoi Map Generation";
            this.btnVoronoi.UseVisualStyleBackColor = true;
            this.btnVoronoi.Click += new System.EventHandler(this.btnVoronoi_Click);
            // 
            // btnGeneration
            // 
            this.btnGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneration.Location = new System.Drawing.Point(220, 169);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(189, 80);
            this.btnGeneration.TabIndex = 3;
            this.btnGeneration.Text = "Dungeon Map Generation";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // btnTunnel
            // 
            this.btnTunnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTunnel.Location = new System.Drawing.Point(25, 255);
            this.btnTunnel.Name = "btnTunnel";
            this.btnTunnel.Size = new System.Drawing.Size(189, 80);
            this.btnTunnel.TabIndex = 4;
            this.btnTunnel.Text = "Tunnel Map Generator";
            this.btnTunnel.UseVisualStyleBackColor = true;
            this.btnTunnel.Click += new System.EventHandler(this.btnTunnel_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrid.Location = new System.Drawing.Point(220, 255);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(189, 80);
            this.btnGrid.TabIndex = 5;
            this.btnGrid.Text = "Grid Map Generated";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 468);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnTunnel);
            this.Controls.Add(this.btnGeneration);
            this.Controls.Add(this.btnVoronoi);
            this.Controls.Add(this.btnPnoise);
            this.Controls.Add(this.btnCell);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCell;
        private System.Windows.Forms.Button btnPnoise;
        private System.Windows.Forms.Button btnVoronoi;
        private System.Windows.Forms.Button btnGeneration;
        private System.Windows.Forms.Button btnTunnel;
        private System.Windows.Forms.Button btnGrid;
    }
}