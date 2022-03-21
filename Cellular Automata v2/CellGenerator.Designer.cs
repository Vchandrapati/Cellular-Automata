namespace Map_Generation
{
    partial class CellGenerator
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCS = new System.Windows.Forms.Label();
            this.lblMW = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.lblCSC = new System.Windows.Forms.Label();
            this.btnLoadRS = new System.Windows.Forms.Button();
            this.tbcs = new System.Windows.Forms.TrackBar();
            this.tbmw = new System.Windows.Forms.TrackBar();
            this.tbmh = new System.Windows.Forms.TrackBar();
            this.tbcss = new System.Windows.Forms.TrackBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbt = new System.Windows.Forms.CheckBox();
            this.cbe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcss)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(2, 2);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(521, 583);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(891, 529);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 56);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Map";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCS.Location = new System.Drawing.Point(696, 15);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(96, 25);
            this.lblCS.TabIndex = 6;
            this.lblCS.Text = "Cell Size:";
            // 
            // lblMW
            // 
            this.lblMW.AutoSize = true;
            this.lblMW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMW.Location = new System.Drawing.Point(678, 82);
            this.lblMW.Name = "lblMW";
            this.lblMW.Size = new System.Drawing.Size(113, 25);
            this.lblMW.TabIndex = 7;
            this.lblMW.Text = "Map Width:";
            // 
            // lblMH
            // 
            this.lblMH.AutoSize = true;
            this.lblMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMH.Location = new System.Drawing.Point(673, 138);
            this.lblMH.Name = "lblMH";
            this.lblMH.Size = new System.Drawing.Size(118, 25);
            this.lblMH.TabIndex = 8;
            this.lblMH.Text = "Map Height:";
            // 
            // lblCSC
            // 
            this.lblCSC.AutoSize = true;
            this.lblCSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSC.Location = new System.Drawing.Point(590, 200);
            this.lblCSC.Name = "lblCSC";
            this.lblCSC.Size = new System.Drawing.Size(201, 25);
            this.lblCSC.TabIndex = 11;
            this.lblCSC.Text = "Cell Survival Chance:";
            // 
            // btnLoadRS
            // 
            this.btnLoadRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRS.Location = new System.Drawing.Point(745, 529);
            this.btnLoadRS.Name = "btnLoadRS";
            this.btnLoadRS.Size = new System.Drawing.Size(140, 56);
            this.btnLoadRS.TabIndex = 12;
            this.btnLoadRS.Text = "Load Standard Ruleset";
            this.btnLoadRS.UseVisualStyleBackColor = true;
            this.btnLoadRS.Click += new System.EventHandler(this.btnLoadRS_Click);
            // 
            // tbcs
            // 
            this.tbcs.Location = new System.Drawing.Point(856, 15);
            this.tbcs.Name = "tbcs";
            this.tbcs.Size = new System.Drawing.Size(321, 56);
            this.tbcs.TabIndex = 13;
            this.tbcs.Scroll += new System.EventHandler(this.tbValue_Changed);
            // 
            // tbmw
            // 
            this.tbmw.Location = new System.Drawing.Point(856, 77);
            this.tbmw.Name = "tbmw";
            this.tbmw.Size = new System.Drawing.Size(321, 56);
            this.tbmw.TabIndex = 14;
            this.tbmw.Scroll += new System.EventHandler(this.tbValue_Changed);
            // 
            // tbmh
            // 
            this.tbmh.Location = new System.Drawing.Point(856, 139);
            this.tbmh.Name = "tbmh";
            this.tbmh.Size = new System.Drawing.Size(321, 56);
            this.tbmh.TabIndex = 15;
            this.tbmh.Scroll += new System.EventHandler(this.tbValue_Changed);
            // 
            // tbcss
            // 
            this.tbcss.Location = new System.Drawing.Point(856, 201);
            this.tbcss.Name = "tbcss";
            this.tbcss.Size = new System.Drawing.Size(321, 56);
            this.tbcss.TabIndex = 16;
            this.tbcss.Scroll += new System.EventHandler(this.tbValue_Changed);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1037, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 56);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Back to Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbt
            // 
            this.cbt.AutoSize = true;
            this.cbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbt.Location = new System.Drawing.Point(964, 263);
            this.cbt.Name = "cbt";
            this.cbt.Size = new System.Drawing.Size(213, 33);
            this.cbt.TabIndex = 18;
            this.cbt.Text = "Spawn Treasure";
            this.cbt.UseVisualStyleBackColor = true;
            // 
            // cbe
            // 
            this.cbe.AutoSize = true;
            this.cbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbe.Location = new System.Drawing.Point(964, 302);
            this.cbe.Name = "cbe";
            this.cbe.Size = new System.Drawing.Size(210, 33);
            this.cbe.TabIndex = 19;
            this.cbe.Text = "Spawn Enemies";
            this.cbe.UseVisualStyleBackColor = true;
            // 
            // CellGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 593);
            this.Controls.Add(this.cbe);
            this.Controls.Add(this.cbt);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbcss);
            this.Controls.Add(this.tbmh);
            this.Controls.Add(this.tbmw);
            this.Controls.Add(this.tbcs);
            this.Controls.Add(this.btnLoadRS);
            this.Controls.Add(this.lblCSC);
            this.Controls.Add(this.lblMH);
            this.Controls.Add(this.lblMW);
            this.Controls.Add(this.lblCS);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbMap);
            this.Name = "CellGenerator";
            this.Text = "Map Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label lblMW;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.Label lblCSC;
        private System.Windows.Forms.Button btnLoadRS;
        private System.Windows.Forms.TrackBar tbcs;
        private System.Windows.Forms.TrackBar tbmw;
        private System.Windows.Forms.TrackBar tbmh;
        private System.Windows.Forms.TrackBar tbcss;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbt;
        private System.Windows.Forms.CheckBox cbe;
    }
}

