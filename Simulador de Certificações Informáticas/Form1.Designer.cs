namespace Simulador_de_Certificações_Informáticas
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.TBuser = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelErro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Member Login";
            // 
            // TBuser
            // 
            this.TBuser.BackColor = System.Drawing.Color.DimGray;
            this.TBuser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuser.ForeColor = System.Drawing.Color.White;
            this.TBuser.Location = new System.Drawing.Point(52, 276);
            this.TBuser.Multiline = true;
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(307, 40);
            this.TBuser.TabIndex = 3;
            this.TBuser.Text = "Username";
            this.TBuser.Click += new System.EventHandler(this.TBuser_Click);
            this.TBuser.TextChanged += new System.EventHandler(this.TBuser_TextChanged);
            // 
            // TBpassword
            // 
            this.TBpassword.BackColor = System.Drawing.Color.DimGray;
            this.TBpassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.ForeColor = System.Drawing.Color.White;
            this.TBpassword.Location = new System.Drawing.Point(52, 349);
            this.TBpassword.Multiline = true;
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '●';
            this.TBpassword.Size = new System.Drawing.Size(258, 40);
            this.TBpassword.TabIndex = 4;
            this.TBpassword.Text = "Password";
            this.TBpassword.Click += new System.EventHandler(this.TBpassword_Click);
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTNLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.ForeColor = System.Drawing.Color.White;
            this.BTNLogin.Location = new System.Drawing.Point(135, 424);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(148, 42);
            this.BTNLogin.TabIndex = 5;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Image = global::Simulador_de_Certificações_Informáticas.Properties.Resources.NotVisible;
            this.btnVisible.Location = new System.Drawing.Point(316, 349);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(43, 40);
            this.btnVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisible.TabIndex = 6;
            this.btnVisible.TabStop = false;
            this.btnVisible.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(354, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 44);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(48, 252);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 21);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            this.labelUsername.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(48, 325);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 21);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            this.labelPassword.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(159, 535);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(101, 21);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Daniel Varela";
            this.labelInfo.Visible = false;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.ForeColor = System.Drawing.Color.White;
            this.labelInfo1.Location = new System.Drawing.Point(180, 556);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(59, 21);
            this.labelInfo1.TabIndex = 10;
            this.labelInfo1.Text = "PI0919";
            this.labelInfo1.Visible = false;
            // 
            // labelErro
            // 
            this.labelErro.AutoSize = true;
            this.labelErro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErro.ForeColor = System.Drawing.Color.Red;
            this.labelErro.Location = new System.Drawing.Point(126, 472);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(166, 21);
            this.labelErro.TabIndex = 11;
            this.labelErro.Text = "Erro ao efetuar Login!!";
            this.labelErro.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(411, 595);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.PictureBox btnVisible;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelErro;
    }
}

