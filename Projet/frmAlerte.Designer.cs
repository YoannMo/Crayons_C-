namespace Projet
{
    partial class frmAlerte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerte));
            this.pctWar = new System.Windows.Forms.PictureBox();
            this.lblAl1 = new System.Windows.Forms.Label();
            this.lblAl2 = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctWar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pctWar
            // 
            this.pctWar.BackColor = System.Drawing.Color.Transparent;
            this.pctWar.Image = ((System.Drawing.Image)(resources.GetObject("pctWar.Image")));
            this.pctWar.Location = new System.Drawing.Point(249, 23);
            this.pctWar.Name = "pctWar";
            this.pctWar.Size = new System.Drawing.Size(100, 81);
            this.pctWar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWar.TabIndex = 0;
            this.pctWar.TabStop = false;
            // 
            // lblAl1
            // 
            this.lblAl1.AutoSize = true;
            this.lblAl1.BackColor = System.Drawing.Color.Transparent;
            this.lblAl1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl1.ForeColor = System.Drawing.Color.Red;
            this.lblAl1.Location = new System.Drawing.Point(127, 128);
            this.lblAl1.Name = "lblAl1";
            this.lblAl1.Size = new System.Drawing.Size(341, 27);
            this.lblAl1.TabIndex = 1;
            this.lblAl1.Text = "Vous n\'avez pas joué votre tour !";
            // 
            // lblAl2
            // 
            this.lblAl2.AutoSize = true;
            this.lblAl2.BackColor = System.Drawing.Color.Transparent;
            this.lblAl2.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAl2.Location = new System.Drawing.Point(111, 176);
            this.lblAl2.Name = "lblAl2";
            this.lblAl2.Size = new System.Drawing.Size(377, 27);
            this.lblAl2.TabIndex = 2;
            this.lblAl2.Text = "Veuillez enlever au moins un objet !";
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(491, 217);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(78, 69);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 90;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(282, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "Revenir au jeu =>";
            // 
            // frmAlerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 285);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.lblAl2);
            this.Controls.Add(this.lblAl1);
            this.Controls.Add(this.pctWar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlerte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlerte";
            ((System.ComponentModel.ISupportInitialize)(this.pctWar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctWar;
        private System.Windows.Forms.Label lblAl1;
        private System.Windows.Forms.Label lblAl2;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label label1;
    }
}