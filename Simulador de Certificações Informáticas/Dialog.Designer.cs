﻿namespace Simulador_de_Certificações_Informáticas
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.TabController = new System.Windows.Forms.TabControl();
            this.simuladorTAB = new System.Windows.Forms.TabPage();
            this.BTNFinish = new System.Windows.Forms.Button();
            this.BTNNext = new System.Windows.Forms.Button();
            this.BTNPrevious = new System.Windows.Forms.Button();
            this.TBResposta4 = new System.Windows.Forms.TextBox();
            this.TBResposta3 = new System.Windows.Forms.TextBox();
            this.TBResposta2 = new System.Windows.Forms.TextBox();
            this.TBResposta1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPergunta = new System.Windows.Forms.TextBox();
            this.IDPergunta = new System.Windows.Forms.TextBox();
            this.BTNIniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNResposta4 = new System.Windows.Forms.Button();
            this.BTNResposta3 = new System.Windows.Forms.Button();
            this.BTNResposta1 = new System.Windows.Forms.Button();
            this.BTNResposta2 = new System.Windows.Forms.Button();
            this.resultsTAB = new System.Windows.Forms.TabPage();
            this.labelPercentagem = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.examesGrid = new System.Windows.Forms.DataGridView();
            this.labelCorretas = new System.Windows.Forms.Label();
            this.labelIncorretas = new System.Windows.Forms.Label();
            this.grafCorretas = new System.Windows.Forms.Panel();
            this.grafIncorretas = new System.Windows.Forms.Panel();
            this.adminTAB = new System.Windows.Forms.TabPage();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnInserirUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lockedIcon = new System.Windows.Forms.PictureBox();
            this.lockedPanel = new System.Windows.Forms.Panel();
            this.TabController.SuspendLayout();
            this.simuladorTAB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.resultsTAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examesGrid)).BeginInit();
            this.adminTAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockedIcon)).BeginInit();
            this.lockedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulador de Certificações | v1.0                                                " +
    "                                       ";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(17, 60);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(104, 25);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Bem Vindo";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(939, 60);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(116, 25);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "dd/mm/yyyy";
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.simuladorTAB);
            this.TabController.Controls.Add(this.resultsTAB);
            this.TabController.Controls.Add(this.adminTAB);
            this.TabController.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabController.Location = new System.Drawing.Point(24, 99);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(1100, 476);
            this.TabController.TabIndex = 6;
            // 
            // simuladorTAB
            // 
            this.simuladorTAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.simuladorTAB.Controls.Add(this.BTNFinish);
            this.simuladorTAB.Controls.Add(this.BTNNext);
            this.simuladorTAB.Controls.Add(this.BTNPrevious);
            this.simuladorTAB.Controls.Add(this.TBResposta4);
            this.simuladorTAB.Controls.Add(this.TBResposta3);
            this.simuladorTAB.Controls.Add(this.TBResposta2);
            this.simuladorTAB.Controls.Add(this.TBResposta1);
            this.simuladorTAB.Controls.Add(this.label9);
            this.simuladorTAB.Controls.Add(this.label8);
            this.simuladorTAB.Controls.Add(this.label7);
            this.simuladorTAB.Controls.Add(this.label6);
            this.simuladorTAB.Controls.Add(this.TBPergunta);
            this.simuladorTAB.Controls.Add(this.IDPergunta);
            this.simuladorTAB.Controls.Add(this.BTNIniciar);
            this.simuladorTAB.Controls.Add(this.label5);
            this.simuladorTAB.Controls.Add(this.label4);
            this.simuladorTAB.Controls.Add(this.panel1);
            this.simuladorTAB.Controls.Add(this.comboBox1);
            this.simuladorTAB.Controls.Add(this.panel2);
            this.simuladorTAB.Location = new System.Drawing.Point(4, 26);
            this.simuladorTAB.Name = "simuladorTAB";
            this.simuladorTAB.Padding = new System.Windows.Forms.Padding(3);
            this.simuladorTAB.Size = new System.Drawing.Size(1092, 446);
            this.simuladorTAB.TabIndex = 0;
            this.simuladorTAB.Text = "Simulador";
            // 
            // BTNFinish
            // 
            this.BTNFinish.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNFinish.ForeColor = System.Drawing.Color.White;
            this.BTNFinish.Location = new System.Drawing.Point(890, 398);
            this.BTNFinish.Name = "BTNFinish";
            this.BTNFinish.Size = new System.Drawing.Size(100, 32);
            this.BTNFinish.TabIndex = 24;
            this.BTNFinish.Text = "Entregar";
            this.BTNFinish.UseVisualStyleBackColor = false;
            this.BTNFinish.Visible = false;
            this.BTNFinish.Click += new System.EventHandler(this.BTNFinish_Click);
            // 
            // BTNNext
            // 
            this.BTNNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNNext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNext.ForeColor = System.Drawing.Color.White;
            this.BTNNext.Location = new System.Drawing.Point(705, 398);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(84, 32);
            this.BTNNext.TabIndex = 23;
            this.BTNNext.Text = ">";
            this.BTNNext.UseVisualStyleBackColor = false;
            this.BTNNext.Visible = false;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // BTNPrevious
            // 
            this.BTNPrevious.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNPrevious.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPrevious.ForeColor = System.Drawing.Color.White;
            this.BTNPrevious.Location = new System.Drawing.Point(603, 398);
            this.BTNPrevious.Name = "BTNPrevious";
            this.BTNPrevious.Size = new System.Drawing.Size(84, 32);
            this.BTNPrevious.TabIndex = 22;
            this.BTNPrevious.Text = "<";
            this.BTNPrevious.UseVisualStyleBackColor = false;
            this.BTNPrevious.Visible = false;
            this.BTNPrevious.Click += new System.EventHandler(this.BTNPrevious_Click);
            // 
            // TBResposta4
            // 
            this.TBResposta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.TBResposta4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResposta4.ForeColor = System.Drawing.Color.White;
            this.TBResposta4.Location = new System.Drawing.Point(354, 348);
            this.TBResposta4.Multiline = true;
            this.TBResposta4.Name = "TBResposta4";
            this.TBResposta4.ReadOnly = true;
            this.TBResposta4.Size = new System.Drawing.Size(636, 34);
            this.TBResposta4.TabIndex = 17;
            // 
            // TBResposta3
            // 
            this.TBResposta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.TBResposta3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResposta3.ForeColor = System.Drawing.Color.White;
            this.TBResposta3.Location = new System.Drawing.Point(354, 287);
            this.TBResposta3.Multiline = true;
            this.TBResposta3.Name = "TBResposta3";
            this.TBResposta3.ReadOnly = true;
            this.TBResposta3.Size = new System.Drawing.Size(636, 34);
            this.TBResposta3.TabIndex = 16;
            // 
            // TBResposta2
            // 
            this.TBResposta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.TBResposta2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResposta2.ForeColor = System.Drawing.Color.White;
            this.TBResposta2.Location = new System.Drawing.Point(354, 223);
            this.TBResposta2.Multiline = true;
            this.TBResposta2.Name = "TBResposta2";
            this.TBResposta2.ReadOnly = true;
            this.TBResposta2.Size = new System.Drawing.Size(636, 34);
            this.TBResposta2.TabIndex = 15;
            // 
            // TBResposta1
            // 
            this.TBResposta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.TBResposta1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBResposta1.ForeColor = System.Drawing.Color.White;
            this.TBResposta1.Location = new System.Drawing.Point(354, 159);
            this.TBResposta1.Multiline = true;
            this.TBResposta1.Name = "TBResposta1";
            this.TBResposta1.ReadOnly = true;
            this.TBResposta1.Size = new System.Drawing.Size(636, 34);
            this.TBResposta1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(305, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "D)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(305, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(305, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "B)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(305, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "A)";
            // 
            // TBPergunta
            // 
            this.TBPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBPergunta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPergunta.ForeColor = System.Drawing.Color.White;
            this.TBPergunta.Location = new System.Drawing.Point(354, 84);
            this.TBPergunta.Multiline = true;
            this.TBPergunta.Name = "TBPergunta";
            this.TBPergunta.ReadOnly = true;
            this.TBPergunta.Size = new System.Drawing.Size(699, 34);
            this.TBPergunta.TabIndex = 9;
            this.TBPergunta.Text = "Por favor, selecione um exame.";
            // 
            // IDPergunta
            // 
            this.IDPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDPergunta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPergunta.ForeColor = System.Drawing.Color.White;
            this.IDPergunta.Location = new System.Drawing.Point(299, 84);
            this.IDPergunta.Multiline = true;
            this.IDPergunta.Name = "IDPergunta";
            this.IDPergunta.ReadOnly = true;
            this.IDPergunta.Size = new System.Drawing.Size(39, 34);
            this.IDPergunta.TabIndex = 8;
            this.IDPergunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNIniciar
            // 
            this.BTNIniciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIniciar.ForeColor = System.Drawing.Color.White;
            this.BTNIniciar.Location = new System.Drawing.Point(521, 29);
            this.BTNIniciar.Name = "BTNIniciar";
            this.BTNIniciar.Size = new System.Drawing.Size(97, 32);
            this.BTNIniciar.TabIndex = 7;
            this.BTNIniciar.Text = "Iniciar";
            this.BTNIniciar.UseVisualStyleBackColor = false;
            this.BTNIniciar.Click += new System.EventHandler(this.BTNIniciar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(770, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Perguntas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(291, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Escolha o exame:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 447);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulador_de_Certificações_Informáticas.Properties.Resources.Microsoft_Office_logo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(Selecione...)",
            "Microsoft Word",
            "Microsoft Excel",
            "Microsoft PowerPoint"});
            this.comboBox1.Location = new System.Drawing.Point(295, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTNResposta4);
            this.panel2.Controls.Add(this.BTNResposta3);
            this.panel2.Controls.Add(this.BTNResposta1);
            this.panel2.Controls.Add(this.BTNResposta2);
            this.panel2.Location = new System.Drawing.Point(1005, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 243);
            this.panel2.TabIndex = 29;
            // 
            // BTNResposta4
            // 
            this.BTNResposta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta4.Location = new System.Drawing.Point(18, 198);
            this.BTNResposta4.Name = "BTNResposta4";
            this.BTNResposta4.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta4.TabIndex = 28;
            this.BTNResposta4.UseVisualStyleBackColor = false;
            this.BTNResposta4.Click += new System.EventHandler(this.BTNResposta4_Click);
            // 
            // BTNResposta3
            // 
            this.BTNResposta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta3.Location = new System.Drawing.Point(18, 137);
            this.BTNResposta3.Name = "BTNResposta3";
            this.BTNResposta3.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta3.TabIndex = 27;
            this.BTNResposta3.UseVisualStyleBackColor = false;
            this.BTNResposta3.Click += new System.EventHandler(this.BTNResposta3_Click);
            // 
            // BTNResposta1
            // 
            this.BTNResposta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta1.Location = new System.Drawing.Point(18, 9);
            this.BTNResposta1.Name = "BTNResposta1";
            this.BTNResposta1.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta1.TabIndex = 25;
            this.BTNResposta1.UseVisualStyleBackColor = false;
            this.BTNResposta1.Click += new System.EventHandler(this.BTNResposta1_Click);
            // 
            // BTNResposta2
            // 
            this.BTNResposta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta2.Location = new System.Drawing.Point(18, 73);
            this.BTNResposta2.Name = "BTNResposta2";
            this.BTNResposta2.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta2.TabIndex = 26;
            this.BTNResposta2.UseVisualStyleBackColor = false;
            this.BTNResposta2.Click += new System.EventHandler(this.BTNResposta2_Click);
            // 
            // resultsTAB
            // 
            this.resultsTAB.BackColor = System.Drawing.Color.DimGray;
            this.resultsTAB.Controls.Add(this.labelPercentagem);
            this.resultsTAB.Controls.Add(this.labelStatus);
            this.resultsTAB.Controls.Add(this.examesGrid);
            this.resultsTAB.Controls.Add(this.labelCorretas);
            this.resultsTAB.Controls.Add(this.labelIncorretas);
            this.resultsTAB.Controls.Add(this.grafCorretas);
            this.resultsTAB.Controls.Add(this.grafIncorretas);
            this.resultsTAB.Location = new System.Drawing.Point(4, 26);
            this.resultsTAB.Name = "resultsTAB";
            this.resultsTAB.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTAB.Size = new System.Drawing.Size(1092, 446);
            this.resultsTAB.TabIndex = 1;
            this.resultsTAB.Text = "Resultados";
            // 
            // labelPercentagem
            // 
            this.labelPercentagem.AutoSize = true;
            this.labelPercentagem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentagem.ForeColor = System.Drawing.Color.White;
            this.labelPercentagem.Location = new System.Drawing.Point(778, 92);
            this.labelPercentagem.Name = "labelPercentagem";
            this.labelPercentagem.Size = new System.Drawing.Size(256, 40);
            this.labelPercentagem.TabIndex = 11;
            this.labelPercentagem.Text = "Percentagem: 0%";
            this.labelPercentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(829, 47);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(101, 40);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examesGrid
            // 
            this.examesGrid.AllowUserToAddRows = false;
            this.examesGrid.AllowUserToDeleteRows = false;
            this.examesGrid.AllowUserToResizeColumns = false;
            this.examesGrid.AllowUserToResizeRows = false;
            this.examesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.examesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examesGrid.Location = new System.Drawing.Point(43, 193);
            this.examesGrid.Name = "examesGrid";
            this.examesGrid.ReadOnly = true;
            this.examesGrid.Size = new System.Drawing.Size(1008, 230);
            this.examesGrid.TabIndex = 8;
            // 
            // labelCorretas
            // 
            this.labelCorretas.AutoSize = true;
            this.labelCorretas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorretas.ForeColor = System.Drawing.Color.White;
            this.labelCorretas.Location = new System.Drawing.Point(41, 104);
            this.labelCorretas.Name = "labelCorretas";
            this.labelCorretas.Size = new System.Drawing.Size(105, 25);
            this.labelCorretas.TabIndex = 7;
            this.labelCorretas.Text = "Corretas - ";
            // 
            // labelIncorretas
            // 
            this.labelIncorretas.AutoSize = true;
            this.labelIncorretas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorretas.ForeColor = System.Drawing.Color.White;
            this.labelIncorretas.Location = new System.Drawing.Point(41, 19);
            this.labelIncorretas.Name = "labelIncorretas";
            this.labelIncorretas.Size = new System.Drawing.Size(115, 25);
            this.labelIncorretas.TabIndex = 6;
            this.labelIncorretas.Text = "Incorretas -";
            // 
            // grafCorretas
            // 
            this.grafCorretas.BackColor = System.Drawing.Color.DodgerBlue;
            this.grafCorretas.Location = new System.Drawing.Point(43, 132);
            this.grafCorretas.Name = "grafCorretas";
            this.grafCorretas.Size = new System.Drawing.Size(50, 45);
            this.grafCorretas.TabIndex = 1;
            // 
            // grafIncorretas
            // 
            this.grafIncorretas.BackColor = System.Drawing.Color.Red;
            this.grafIncorretas.Location = new System.Drawing.Point(43, 47);
            this.grafIncorretas.Name = "grafIncorretas";
            this.grafIncorretas.Size = new System.Drawing.Size(50, 45);
            this.grafIncorretas.TabIndex = 0;
            // 
            // adminTAB
            // 
            this.adminTAB.BackColor = System.Drawing.Color.DimGray;
            this.adminTAB.Controls.Add(this.lockedPanel);
            this.adminTAB.Controls.Add(this.labelPassword);
            this.adminTAB.Controls.Add(this.labelID);
            this.adminTAB.Controls.Add(this.labelUsername);
            this.adminTAB.Controls.Add(this.btnInserirUser);
            this.adminTAB.Controls.Add(this.btnUpdateUser);
            this.adminTAB.Controls.Add(this.tbID);
            this.adminTAB.Controls.Add(this.label2);
            this.adminTAB.Controls.Add(this.cbLevel);
            this.adminTAB.Controls.Add(this.tbUser);
            this.adminTAB.Controls.Add(this.tbPassword);
            this.adminTAB.Controls.Add(this.btnDeleteUser);
            this.adminTAB.Controls.Add(this.dataGridViewUsers);
            this.adminTAB.Location = new System.Drawing.Point(4, 26);
            this.adminTAB.Name = "adminTAB";
            this.adminTAB.Padding = new System.Windows.Forms.Padding(3);
            this.adminTAB.Size = new System.Drawing.Size(1092, 446);
            this.adminTAB.TabIndex = 2;
            this.adminTAB.Text = "Gestão Users";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(626, 96);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 21);
            this.labelPassword.TabIndex = 34;
            this.labelPassword.Text = "Password";
            this.labelPassword.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(30, 6);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 21);
            this.labelID.TabIndex = 33;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(25, 96);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 21);
            this.labelUsername.TabIndex = 32;
            this.labelUsername.Text = "Username";
            this.labelUsername.Visible = false;
            // 
            // btnInserirUser
            // 
            this.btnInserirUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInserirUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirUser.ForeColor = System.Drawing.Color.White;
            this.btnInserirUser.Location = new System.Drawing.Point(935, 183);
            this.btnInserirUser.Name = "btnInserirUser";
            this.btnInserirUser.Size = new System.Drawing.Size(148, 45);
            this.btnInserirUser.TabIndex = 31;
            this.btnInserirUser.Text = "Inserir User";
            this.btnInserirUser.UseVisualStyleBackColor = false;
            this.btnInserirUser.Click += new System.EventHandler(this.btnInserirUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(935, 278);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(148, 45);
            this.btnUpdateUser.TabIndex = 30;
            this.btnUpdateUser.Text = "Atualizar User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.White;
            this.tbID.Location = new System.Drawing.Point(30, 29);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(298, 40);
            this.tbID.TabIndex = 29;
            this.tbID.Text = "ID";
            this.tbID.Click += new System.EventHandler(this.tbID_Click);
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(557, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nível de Acesso:";
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.ForeColor = System.Drawing.Color.White;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Utilizador",
            "Admin"});
            this.cbLevel.Location = new System.Drawing.Point(719, 29);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(205, 29);
            this.cbLevel.TabIndex = 27;
            this.cbLevel.Text = "(Selecione...)";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.White;
            this.tbUser.Location = new System.Drawing.Point(30, 119);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(298, 40);
            this.tbUser.TabIndex = 26;
            this.tbUser.Text = "Username";
            this.tbUser.Click += new System.EventHandler(this.tbUser_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(626, 119);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(298, 40);
            this.tbPassword.TabIndex = 25;
            this.tbPassword.Text = "Password";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(935, 373);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteUser.TabIndex = 24;
            this.btnDeleteUser.Text = "Eliminar User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewUsers.Location = new System.Drawing.Point(30, 183);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(894, 234);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1093, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lockedIcon
            // 
            this.lockedIcon.Image = ((System.Drawing.Image)(resources.GetObject("lockedIcon.Image")));
            this.lockedIcon.Location = new System.Drawing.Point(444, 107);
            this.lockedIcon.Name = "lockedIcon";
            this.lockedIcon.Size = new System.Drawing.Size(207, 206);
            this.lockedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockedIcon.TabIndex = 0;
            this.lockedIcon.TabStop = false;
            // 
            // lockedPanel
            // 
            this.lockedPanel.BackColor = System.Drawing.Color.DimGray;
            this.lockedPanel.Controls.Add(this.lockedIcon);
            this.lockedPanel.Location = new System.Drawing.Point(0, 0);
            this.lockedPanel.Name = "lockedPanel";
            this.lockedPanel.Size = new System.Drawing.Size(1092, 446);
            this.lockedPanel.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.TabController);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.TabController.ResumeLayout(false);
            this.simuladorTAB.ResumeLayout(false);
            this.simuladorTAB.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.resultsTAB.ResumeLayout(false);
            this.resultsTAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examesGrid)).EndInit();
            this.adminTAB.ResumeLayout(false);
            this.adminTAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockedIcon)).EndInit();
            this.lockedPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage simuladorTAB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage resultsTAB;
        private System.Windows.Forms.TabPage adminTAB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNIniciar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPergunta;
        private System.Windows.Forms.TextBox IDPergunta;
        private System.Windows.Forms.Button BTNNext;
        private System.Windows.Forms.Button BTNPrevious;
        private System.Windows.Forms.TextBox TBResposta4;
        private System.Windows.Forms.TextBox TBResposta3;
        private System.Windows.Forms.TextBox TBResposta2;
        private System.Windows.Forms.TextBox TBResposta1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNFinish;
        private System.Windows.Forms.Button BTNResposta1;
        private System.Windows.Forms.Button BTNResposta4;
        private System.Windows.Forms.Button BTNResposta3;
        private System.Windows.Forms.Button BTNResposta2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnInserirUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel grafCorretas;
        private System.Windows.Forms.Panel grafIncorretas;
        private System.Windows.Forms.Label labelCorretas;
        private System.Windows.Forms.Label labelIncorretas;
        private System.Windows.Forms.DataGridView examesGrid;
        private System.Windows.Forms.Label labelPercentagem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel lockedPanel;
        private System.Windows.Forms.PictureBox lockedIcon;
    }
}