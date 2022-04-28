namespace Simulador_de_Certificações_Informáticas
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
            this.resultsTAB = new System.Windows.Forms.TabPage();
            this.adminTAB = new System.Windows.Forms.TabPage();
            this.lockedPanel = new System.Windows.Forms.Panel();
            this.lockedIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTNResposta1 = new System.Windows.Forms.Button();
            this.BTNResposta2 = new System.Windows.Forms.Button();
            this.BTNResposta3 = new System.Windows.Forms.Button();
            this.BTNResposta4 = new System.Windows.Forms.Button();
            this.TabController.SuspendLayout();
            this.simuladorTAB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adminTAB.SuspendLayout();
            this.lockedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.simuladorTAB.Controls.Add(this.BTNResposta4);
            this.simuladorTAB.Controls.Add(this.BTNResposta3);
            this.simuladorTAB.Controls.Add(this.BTNResposta2);
            this.simuladorTAB.Controls.Add(this.BTNResposta1);
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
            // resultsTAB
            // 
            this.resultsTAB.BackColor = System.Drawing.Color.DimGray;
            this.resultsTAB.Location = new System.Drawing.Point(4, 26);
            this.resultsTAB.Name = "resultsTAB";
            this.resultsTAB.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTAB.Size = new System.Drawing.Size(1092, 446);
            this.resultsTAB.TabIndex = 1;
            this.resultsTAB.Text = "Resultados";
            // 
            // adminTAB
            // 
            this.adminTAB.BackColor = System.Drawing.Color.DimGray;
            this.adminTAB.Controls.Add(this.lockedPanel);
            this.adminTAB.Location = new System.Drawing.Point(4, 26);
            this.adminTAB.Name = "adminTAB";
            this.adminTAB.Padding = new System.Windows.Forms.Padding(3);
            this.adminTAB.Size = new System.Drawing.Size(1092, 446);
            this.adminTAB.TabIndex = 2;
            this.adminTAB.Text = "Gestão Users";
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
            // BTNResposta1
            // 
            this.BTNResposta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta1.Location = new System.Drawing.Point(1023, 159);
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
            this.BTNResposta2.Location = new System.Drawing.Point(1023, 223);
            this.BTNResposta2.Name = "BTNResposta2";
            this.BTNResposta2.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta2.TabIndex = 26;
            this.BTNResposta2.UseVisualStyleBackColor = false;
            this.BTNResposta2.Click += new System.EventHandler(this.BTNResposta2_Click);
            // 
            // BTNResposta3
            // 
            this.BTNResposta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta3.Location = new System.Drawing.Point(1023, 287);
            this.BTNResposta3.Name = "BTNResposta3";
            this.BTNResposta3.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta3.TabIndex = 27;
            this.BTNResposta3.UseVisualStyleBackColor = false;
            this.BTNResposta3.Click += new System.EventHandler(this.BTNResposta3_Click);
            // 
            // BTNResposta4
            // 
            this.BTNResposta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BTNResposta4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNResposta4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNResposta4.Location = new System.Drawing.Point(1023, 348);
            this.BTNResposta4.Name = "BTNResposta4";
            this.BTNResposta4.Size = new System.Drawing.Size(35, 34);
            this.BTNResposta4.TabIndex = 28;
            this.BTNResposta4.UseVisualStyleBackColor = false;
            this.BTNResposta4.Click += new System.EventHandler(this.BTNResposta4_Click);
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
            this.adminTAB.ResumeLayout(false);
            this.lockedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lockedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel lockedPanel;
        private System.Windows.Forms.PictureBox lockedIcon;
        private System.Windows.Forms.Button BTNResposta1;
        private System.Windows.Forms.Button BTNResposta4;
        private System.Windows.Forms.Button BTNResposta3;
        private System.Windows.Forms.Button BTNResposta2;
    }
}