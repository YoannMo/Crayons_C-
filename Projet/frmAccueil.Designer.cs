﻿namespace Projet
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
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNiv1 = new System.Windows.Forms.Button();
            this.cmdNiv2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(160, 310);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(147, 51);
            this.cmdHelp.TabIndex = 0;
            this.cmdHelp.Text = "Principe du jeu";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(160, 400);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(147, 51);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Quitter ";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(160, 226);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(147, 50);
            this.cmdPlay.TabIndex = 2;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jeu de Nim";
            // 
            // cmdNiv1
            // 
            this.cmdNiv1.Location = new System.Drawing.Point(160, 226);
            this.cmdNiv1.Name = "cmdNiv1";
            this.cmdNiv1.Size = new System.Drawing.Size(67, 50);
            this.cmdNiv1.TabIndex = 4;
            this.cmdNiv1.Text = "Facile";
            this.cmdNiv1.UseVisualStyleBackColor = true;
            this.cmdNiv1.Click += new System.EventHandler(this.cmdNiv1_Click);
            // 
            // cmdNiv2
            // 
            this.cmdNiv2.Location = new System.Drawing.Point(245, 226);
            this.cmdNiv2.Name = "cmdNiv2";
            this.cmdNiv2.Size = new System.Drawing.Size(62, 50);
            this.cmdNiv2.TabIndex = 5;
            this.cmdNiv2.Text = "Difficile";
            this.cmdNiv2.UseVisualStyleBackColor = true;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 579);
            this.Controls.Add(this.cmdNiv2);
            this.Controls.Add(this.cmdNiv1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdHelp);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNiv1;
        private System.Windows.Forms.Button cmdNiv2;
    }
}