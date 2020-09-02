namespace acsu_lövős
{
    partial class kepernyo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kepernyo));
            this.acsu = new System.Windows.Forms.PictureBox();
            this.szoveg1 = new System.Windows.Forms.Label();
            this.szoveg2 = new System.Windows.Forms.Label();
            this.szoveg3 = new System.Windows.Forms.Label();
            this.kilep = new System.Windows.Forms.Button();
            this.ujrakezd = new System.Windows.Forms.Button();
            this.idozito = new System.Windows.Forms.Timer(this.components);
            this.szoveg4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acsu)).BeginInit();
            this.SuspendLayout();
            // 
            // acsu
            // 
            this.acsu.BackColor = System.Drawing.Color.Transparent;
            this.acsu.Image = ((System.Drawing.Image)(resources.GetObject("acsu.Image")));
            this.acsu.Location = new System.Drawing.Point(191, 314);
            this.acsu.Name = "acsu";
            this.acsu.Size = new System.Drawing.Size(95, 114);
            this.acsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acsu.TabIndex = 0;
            this.acsu.TabStop = false;
            this.acsu.Click += new System.EventHandler(this.acsu_Click);
            // 
            // szoveg1
            // 
            this.szoveg1.AutoSize = true;
            this.szoveg1.BackColor = System.Drawing.Color.Transparent;
            this.szoveg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg1.Location = new System.Drawing.Point(12, 9);
            this.szoveg1.Name = "szoveg1";
            this.szoveg1.Size = new System.Drawing.Size(109, 44);
            this.szoveg1.TabIndex = 1;
            this.szoveg1.Text = "Pont:";
            // 
            // szoveg2
            // 
            this.szoveg2.AutoSize = true;
            this.szoveg2.BackColor = System.Drawing.Color.Transparent;
            this.szoveg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg2.Location = new System.Drawing.Point(12, 62);
            this.szoveg2.Name = "szoveg2";
            this.szoveg2.Size = new System.Drawing.Size(199, 44);
            this.szoveg2.TabIndex = 2;
            this.szoveg2.Text = "Szar vagy:";
            // 
            // szoveg3
            // 
            this.szoveg3.AutoSize = true;
            this.szoveg3.BackColor = System.Drawing.Color.Transparent;
            this.szoveg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg3.Location = new System.Drawing.Point(12, 116);
            this.szoveg3.Name = "szoveg3";
            this.szoveg3.Size = new System.Drawing.Size(228, 44);
            this.szoveg3.TabIndex = 3;
            this.szoveg3.Text = "Össz. lövés:";
            // 
            // kilep
            // 
            this.kilep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilep.Location = new System.Drawing.Point(1091, 30);
            this.kilep.Name = "kilep";
            this.kilep.Size = new System.Drawing.Size(144, 46);
            this.kilep.TabIndex = 4;
            this.kilep.Text = "Kilépés";
            this.kilep.UseVisualStyleBackColor = true;
            this.kilep.Click += new System.EventHandler(this.kilep_Click);
            // 
            // ujrakezd
            // 
            this.ujrakezd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ujrakezd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujrakezd.Location = new System.Drawing.Point(1091, 104);
            this.ujrakezd.Name = "ujrakezd";
            this.ujrakezd.Size = new System.Drawing.Size(144, 46);
            this.ujrakezd.TabIndex = 5;
            this.ujrakezd.Text = "ÚJRA";
            this.ujrakezd.UseVisualStyleBackColor = true;
            this.ujrakezd.Click += new System.EventHandler(this.ujrakezd_Click);
            // 
            // idozito
            // 
            this.idozito.Enabled = true;
            this.idozito.Interval = 1000;
            this.idozito.Tick += new System.EventHandler(this.idozito_Tick);
            // 
            // szoveg4
            // 
            this.szoveg4.AutoSize = true;
            this.szoveg4.BackColor = System.Drawing.Color.Transparent;
            this.szoveg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szoveg4.Location = new System.Drawing.Point(231, 160);
            this.szoveg4.Name = "szoveg4";
            this.szoveg4.Size = new System.Drawing.Size(0, 55);
            this.szoveg4.TabIndex = 6;
            // 
            // kepernyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1272, 803);
            this.Controls.Add(this.szoveg4);
            this.Controls.Add(this.ujrakezd);
            this.Controls.Add(this.kilep);
            this.Controls.Add(this.szoveg3);
            this.Controls.Add(this.szoveg2);
            this.Controls.Add(this.szoveg1);
            this.Controls.Add(this.acsu);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1290, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1290, 850);
            this.Name = "kepernyo";
            this.Text = "Kill the faszfej";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kepernyo_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.acsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox acsu;
        private System.Windows.Forms.Label szoveg1;
        private System.Windows.Forms.Label szoveg2;
        private System.Windows.Forms.Label szoveg3;
        private System.Windows.Forms.Button kilep;
        private System.Windows.Forms.Button ujrakezd;
        private System.Windows.Forms.Timer idozito;
        private System.Windows.Forms.Label szoveg4;
    }
}

