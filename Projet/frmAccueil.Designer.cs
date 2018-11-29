namespace Projet
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.label1 = new System.Windows.Forms.Label();
            this.lblEz = new System.Windows.Forms.Label();
            this.cmdNiv1 = new System.Windows.Forms.PictureBox();
            this.lblHard = new System.Windows.Forms.Label();
            this.cmdNiv2 = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.cmdPlay = new System.Windows.Forms.Label();
            this.cmdHelp = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Label();
            this.pctTrait1 = new System.Windows.Forms.PictureBox();
            this.pctTrait2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jeu de Nim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEz
            // 
            this.lblEz.AutoSize = true;
            this.lblEz.BackColor = System.Drawing.Color.Transparent;
            this.lblEz.Font = new System.Drawing.Font("Vivaldi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEz.Location = new System.Drawing.Point(92, 212);
            this.lblEz.Name = "lblEz";
            this.lblEz.Size = new System.Drawing.Size(108, 42);
            this.lblEz.TabIndex = 6;
            this.lblEz.Text = "Facile";
            this.lblEz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdNiv1
            // 
            this.cmdNiv1.BackColor = System.Drawing.Color.Transparent;
            this.cmdNiv1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNiv1.Image = ((System.Drawing.Image)(resources.GetObject("cmdNiv1.Image")));
            this.cmdNiv1.Location = new System.Drawing.Point(85, 267);
            this.cmdNiv1.Name = "cmdNiv1";
            this.cmdNiv1.Size = new System.Drawing.Size(131, 113);
            this.cmdNiv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdNiv1.TabIndex = 7;
            this.cmdNiv1.TabStop = false;
            this.cmdNiv1.Click += new System.EventHandler(this.cmdNiv1_Click);
            // 
            // lblHard
            // 
            this.lblHard.AutoSize = true;
            this.lblHard.BackColor = System.Drawing.Color.Transparent;
            this.lblHard.Font = new System.Drawing.Font("Vivaldi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard.Location = new System.Drawing.Point(505, 212);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(124, 42);
            this.lblHard.TabIndex = 8;
            this.lblHard.Text = "Difficile";
            this.lblHard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdNiv2
            // 
            this.cmdNiv2.BackColor = System.Drawing.Color.Transparent;
            this.cmdNiv2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNiv2.Image = ((System.Drawing.Image)(resources.GetObject("cmdNiv2.Image")));
            this.cmdNiv2.Location = new System.Drawing.Point(512, 267);
            this.cmdNiv2.Name = "cmdNiv2";
            this.cmdNiv2.Size = new System.Drawing.Size(131, 113);
            this.cmdNiv2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdNiv2.TabIndex = 9;
            this.cmdNiv2.TabStop = false;
            this.cmdNiv2.Click += new System.EventHandler(this.cmdNiv2_Click);
            // 
            // pctExit
            // 
            this.pctExit.BackColor = System.Drawing.Color.Transparent;
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(619, 450);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(123, 100);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 41;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.AutoSize = true;
            this.cmdPlay.BackColor = System.Drawing.Color.Transparent;
            this.cmdPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPlay.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlay.Location = new System.Drawing.Point(315, 240);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(105, 44);
            this.cmdPlay.TabIndex = 42;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.AutoSize = true;
            this.cmdHelp.BackColor = System.Drawing.Color.Transparent;
            this.cmdHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHelp.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Location = new System.Drawing.Point(313, 349);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(117, 44);
            this.cmdHelp.TabIndex = 43;
            this.cmdHelp.Text = "Règles";
            this.cmdHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.AutoSize = true;
            this.cmdExit.BackColor = System.Drawing.Color.Transparent;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExit.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(313, 456);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(118, 44);
            this.cmdExit.TabIndex = 44;
            this.cmdExit.Text = "Quitter";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // pctTrait1
            // 
            this.pctTrait1.BackColor = System.Drawing.Color.Transparent;
            this.pctTrait1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTrait1.Image = ((System.Drawing.Image)(resources.GetObject("pctTrait1.Image")));
            this.pctTrait1.Location = new System.Drawing.Point(235, 289);
            this.pctTrait1.Name = "pctTrait1";
            this.pctTrait1.Size = new System.Drawing.Size(271, 57);
            this.pctTrait1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTrait1.TabIndex = 45;
            this.pctTrait1.TabStop = false;
            // 
            // pctTrait2
            // 
            this.pctTrait2.BackColor = System.Drawing.Color.Transparent;
            this.pctTrait2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTrait2.Image = ((System.Drawing.Image)(resources.GetObject("pctTrait2.Image")));
            this.pctTrait2.Location = new System.Drawing.Point(235, 396);
            this.pctTrait2.Name = "pctTrait2";
            this.pctTrait2.Size = new System.Drawing.Size(271, 57);
            this.pctTrait2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTrait2.TabIndex = 46;
            this.pctTrait2.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pctTrait2);
            this.Controls.Add(this.pctTrait1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.cmdNiv2);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.cmdNiv1);
            this.Controls.Add(this.lblEz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEz;
        private System.Windows.Forms.PictureBox cmdNiv1;
        private System.Windows.Forms.Label lblHard;
        private System.Windows.Forms.PictureBox cmdNiv2;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label cmdPlay;
        private System.Windows.Forms.Label cmdHelp;
        private System.Windows.Forms.Label cmdExit;
        private System.Windows.Forms.PictureBox pctTrait1;
        private System.Windows.Forms.PictureBox pctTrait2;
    }
}