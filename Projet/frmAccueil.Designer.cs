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
            this.lblJeu = new System.Windows.Forms.Label();
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
            this.pctEtEz = new System.Windows.Forms.PictureBox();
            this.pctEtHa3 = new System.Windows.Forms.PictureBox();
            this.pctEtHa2 = new System.Windows.Forms.PictureBox();
            this.pctEtHa1 = new System.Windows.Forms.PictureBox();
            this.lblSolo = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.lblGo = new System.Windows.Forms.Label();
            this.pctGl = new System.Windows.Forms.PictureBox();
            this.lblTxt4 = new System.Windows.Forms.Label();
            this.lblTxt3 = new System.Windows.Forms.Label();
            this.lblTxt2 = new System.Windows.Forms.Label();
            this.lblTxt1 = new System.Windows.Forms.Label();
            this.lblRegles = new System.Windows.Forms.Label();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.lblBack1 = new System.Windows.Forms.Label();
            this.lblBack2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdNiv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrait2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtEz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJeu
            // 
            this.lblJeu.AutoSize = true;
            this.lblJeu.BackColor = System.Drawing.Color.Transparent;
            this.lblJeu.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJeu.Location = new System.Drawing.Point(196, 95);
            this.lblJeu.Name = "lblJeu";
            this.lblJeu.Size = new System.Drawing.Size(345, 76);
            this.lblJeu.TabIndex = 3;
            this.lblJeu.Text = "Jeu de Nim";
            this.lblJeu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // pctEtEz
            // 
            this.pctEtEz.BackColor = System.Drawing.Color.Transparent;
            this.pctEtEz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEtEz.Image = ((System.Drawing.Image)(resources.GetObject("pctEtEz.Image")));
            this.pctEtEz.Location = new System.Drawing.Point(131, 396);
            this.pctEtEz.Name = "pctEtEz";
            this.pctEtEz.Size = new System.Drawing.Size(39, 32);
            this.pctEtEz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEtEz.TabIndex = 47;
            this.pctEtEz.TabStop = false;
            // 
            // pctEtHa3
            // 
            this.pctEtHa3.BackColor = System.Drawing.Color.Transparent;
            this.pctEtHa3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEtHa3.Image = ((System.Drawing.Image)(resources.GetObject("pctEtHa3.Image")));
            this.pctEtHa3.Location = new System.Drawing.Point(604, 396);
            this.pctEtHa3.Name = "pctEtHa3";
            this.pctEtHa3.Size = new System.Drawing.Size(39, 32);
            this.pctEtHa3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEtHa3.TabIndex = 52;
            this.pctEtHa3.TabStop = false;
            // 
            // pctEtHa2
            // 
            this.pctEtHa2.BackColor = System.Drawing.Color.Transparent;
            this.pctEtHa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEtHa2.Image = ((System.Drawing.Image)(resources.GetObject("pctEtHa2.Image")));
            this.pctEtHa2.Location = new System.Drawing.Point(557, 396);
            this.pctEtHa2.Name = "pctEtHa2";
            this.pctEtHa2.Size = new System.Drawing.Size(39, 32);
            this.pctEtHa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEtHa2.TabIndex = 51;
            this.pctEtHa2.TabStop = false;
            // 
            // pctEtHa1
            // 
            this.pctEtHa1.BackColor = System.Drawing.Color.Transparent;
            this.pctEtHa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEtHa1.Image = ((System.Drawing.Image)(resources.GetObject("pctEtHa1.Image")));
            this.pctEtHa1.Location = new System.Drawing.Point(512, 396);
            this.pctEtHa1.Name = "pctEtHa1";
            this.pctEtHa1.Size = new System.Drawing.Size(39, 32);
            this.pctEtHa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEtHa1.TabIndex = 50;
            this.pctEtHa1.TabStop = false;
            // 
            // lblSolo
            // 
            this.lblSolo.AutoSize = true;
            this.lblSolo.BackColor = System.Drawing.Color.Transparent;
            this.lblSolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSolo.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolo.Location = new System.Drawing.Point(321, 242);
            this.lblSolo.Name = "lblSolo";
            this.lblSolo.Size = new System.Drawing.Size(99, 44);
            this.lblSolo.TabIndex = 53;
            this.lblSolo.Text = "Solo";
            this.lblSolo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSolo.Click += new System.EventHandler(this.lblSolo_Click);
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.BackColor = System.Drawing.Color.Transparent;
            this.lblMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMulti.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.Location = new System.Drawing.Point(312, 349);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(108, 44);
            this.lblMulti.TabIndex = 54;
            this.lblMulti.Text = "Multi";
            this.lblMulti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMulti.Click += new System.EventHandler(this.lblMulti_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Vivaldi", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 95);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(714, 76);
            this.lblTitre.TabIndex = 55;
            this.lblTitre.Text = "Entrez le nom des deux joueurs:";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblJ1.Font = new System.Drawing.Font("Vivaldi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.Location = new System.Drawing.Point(149, 240);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(157, 42);
            this.lblJ1.TabIndex = 56;
            this.lblJ1.Text = "Joueur 1 :";
            this.lblJ1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblJ2.Font = new System.Drawing.Font("Vivaldi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.Location = new System.Drawing.Point(439, 240);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(157, 42);
            this.lblJ2.TabIndex = 57;
            this.lblJ2.Text = "Joueur 2 :";
            this.lblJ2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(156, 360);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(150, 20);
            this.txtJ1.TabIndex = 58;
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(446, 360);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(150, 20);
            this.txtJ2.TabIndex = 59;
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblGo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGo.Font = new System.Drawing.Font("Vivaldi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGo.Location = new System.Drawing.Point(299, 450);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(149, 46);
            this.lblGo.TabIndex = 60;
            this.lblGo.Text = "Lancer ! ";
            this.lblGo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGo.Click += new System.EventHandler(this.lblGo_Click);
            // 
            // pctGl
            // 
            this.pctGl.BackColor = System.Drawing.Color.Transparent;
            this.pctGl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctGl.Image = ((System.Drawing.Image)(resources.GetObject("pctGl.Image")));
            this.pctGl.Location = new System.Drawing.Point(208, 383);
            this.pctGl.Name = "pctGl";
            this.pctGl.Size = new System.Drawing.Size(305, 149);
            this.pctGl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGl.TabIndex = 67;
            this.pctGl.TabStop = false;
            // 
            // lblTxt4
            // 
            this.lblTxt4.AutoSize = true;
            this.lblTxt4.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt4.Font = new System.Drawing.Font("Vivaldi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt4.Location = new System.Drawing.Point(150, 314);
            this.lblTxt4.Name = "lblTxt4";
            this.lblTxt4.Size = new System.Drawing.Size(413, 32);
            this.lblTxt4.TabIndex = 65;
            this.lblTxt4.Text = "3: Enlever le dernier crayon pour gagner!";
            // 
            // lblTxt3
            // 
            this.lblTxt3.AutoSize = true;
            this.lblTxt3.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt3.Font = new System.Drawing.Font("Vivaldi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt3.Location = new System.Drawing.Point(150, 254);
            this.lblTxt3.Name = "lblTxt3";
            this.lblTxt3.Size = new System.Drawing.Size(428, 32);
            this.lblTxt3.TabIndex = 64;
            this.lblTxt3.Text = "2: Enlever à tour de rôle 1,2 ou 3 crayons.";
            // 
            // lblTxt2
            // 
            this.lblTxt2.AutoSize = true;
            this.lblTxt2.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt2.Font = new System.Drawing.Font("Vivaldi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt2.Location = new System.Drawing.Point(191, 196);
            this.lblTxt2.Name = "lblTxt2";
            this.lblTxt2.Size = new System.Drawing.Size(326, 32);
            this.lblTxt2.TabIndex = 63;
            this.lblTxt2.Text = "1: Choisir de commencer ou non ";
            // 
            // lblTxt1
            // 
            this.lblTxt1.AutoSize = true;
            this.lblTxt1.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt1.Font = new System.Drawing.Font("Vivaldi", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt1.Location = new System.Drawing.Point(263, 138);
            this.lblTxt1.Name = "lblTxt1";
            this.lblTxt1.Size = new System.Drawing.Size(194, 32);
            this.lblTxt1.TabIndex = 62;
            this.lblTxt1.Text = "Il y a 15 crayons";
            // 
            // lblRegles
            // 
            this.lblRegles.AutoSize = true;
            this.lblRegles.BackColor = System.Drawing.Color.Transparent;
            this.lblRegles.Font = new System.Drawing.Font("Vivaldi", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegles.Location = new System.Drawing.Point(121, 9);
            this.lblRegles.Name = "lblRegles";
            this.lblRegles.Size = new System.Drawing.Size(497, 114);
            this.lblRegles.TabIndex = 61;
            this.lblRegles.Text = "Règles du jeu";
            // 
            // pctBack
            // 
            this.pctBack.BackColor = System.Drawing.Color.Transparent;
            this.pctBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBack.Image = ((System.Drawing.Image)(resources.GetObject("pctBack.Image")));
            this.pctBack.Location = new System.Drawing.Point(25, 471);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(77, 61);
            this.pctBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBack.TabIndex = 68;
            this.pctBack.TabStop = false;
            this.pctBack.Click += new System.EventHandler(this.pctBack_Click);
            // 
            // lblBack1
            // 
            this.lblBack1.AutoSize = true;
            this.lblBack1.BackColor = System.Drawing.Color.Transparent;
            this.lblBack1.Font = new System.Drawing.Font("Vivaldi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack1.Location = new System.Drawing.Point(95, 472);
            this.lblBack1.Name = "lblBack1";
            this.lblBack1.Size = new System.Drawing.Size(48, 22);
            this.lblBack1.TabIndex = 69;
            this.lblBack1.Text = "Solo";
            this.lblBack1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBack2
            // 
            this.lblBack2.AutoSize = true;
            this.lblBack2.BackColor = System.Drawing.Color.Transparent;
            this.lblBack2.Font = new System.Drawing.Font("Vivaldi", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack2.Location = new System.Drawing.Point(95, 510);
            this.lblBack2.Name = "lblBack2";
            this.lblBack2.Size = new System.Drawing.Size(53, 22);
            this.lblBack2.TabIndex = 70;
            this.lblBack2.Text = "Multi";
            this.lblBack2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.ControlBox = false;
            this.Controls.Add(this.lblBack2);
            this.Controls.Add(this.lblBack1);
            this.Controls.Add(this.pctBack);
            this.Controls.Add(this.pctGl);
            this.Controls.Add(this.lblTxt4);
            this.Controls.Add(this.lblTxt3);
            this.Controls.Add(this.lblTxt2);
            this.Controls.Add(this.lblTxt1);
            this.Controls.Add(this.lblRegles);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.txtJ2);
            this.Controls.Add(this.txtJ1);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblSolo);
            this.Controls.Add(this.pctEtHa3);
            this.Controls.Add(this.pctEtHa2);
            this.Controls.Add(this.pctEtHa1);
            this.Controls.Add(this.pctEtEz);
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
            this.Controls.Add(this.lblJeu);
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
            ((System.ComponentModel.ISupportInitialize)(this.pctEtEz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEtHa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJeu;
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
        private System.Windows.Forms.PictureBox pctEtEz;
        private System.Windows.Forms.PictureBox pctEtHa3;
        private System.Windows.Forms.PictureBox pctEtHa2;
        private System.Windows.Forms.PictureBox pctEtHa1;
        private System.Windows.Forms.Label lblSolo;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.TextBox txtJ1;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.PictureBox pctGl;
        private System.Windows.Forms.Label lblTxt4;
        private System.Windows.Forms.Label lblTxt3;
        private System.Windows.Forms.Label lblTxt2;
        private System.Windows.Forms.Label lblTxt1;
        private System.Windows.Forms.Label lblRegles;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.Label lblBack1;
        private System.Windows.Forms.Label lblBack2;
    }
}