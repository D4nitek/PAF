using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Certificações_Informáticas
{
    public partial class HomePage : Form
    {
        bool btn1Selected = false;
        bool btn2Selected = false;
        bool btn3Selected = false;
        bool btn4Selected = false;

        //Faz com que fique com rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );


        public HomePage(string username, int level)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelWelcome.Text = "Bem vindo " + username + " | Nível de Acesso: " + ((level > 0) ? "Administrador" : "Utilizador");
            labelData.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Tem a ceteza que deseja sair?","Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
                Application.Exit();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            TabController.Focus();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.Microsoft_Office_logo;
                    TBPergunta.Text = "Por favor, selecione um exame.";
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.Microsoft_Word_Logo;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.microsoft_office_excel_logo_icon_145720;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Microsoft_PowerPoint_Logo_wine;
                    break;
            }
        }

        private void BTNResposta1_Click(object sender, EventArgs e)
        {
            if (BTNResposta1.BackColor == Color.FromArgb(106, 106, 106))
            {
                BTNResposta1.BackColor = Color.DodgerBlue;
                btn1Selected = true;
            }
            else
            {
                BTNResposta1.BackColor = Color.FromArgb(106, 106, 106);
                btn1Selected = false;
            }   
        }

        private void BTNResposta2_Click(object sender, EventArgs e)
        {
            if (BTNResposta2.BackColor == Color.FromArgb(106, 106, 106))
            {
                BTNResposta2.BackColor = Color.DodgerBlue;
                btn2Selected = true;
            }
            else
            {
                BTNResposta2.BackColor = Color.FromArgb(106, 106, 106);
                btn2Selected = false;
            }
        }

        private void BTNResposta3_Click(object sender, EventArgs e)
        {
            if (BTNResposta3.BackColor == Color.FromArgb(106, 106, 106))
            {
                BTNResposta3.BackColor = Color.DodgerBlue;
                btn3Selected = true;
            }
            else
            {
                BTNResposta3.BackColor = Color.FromArgb(106, 106, 106);
                btn3Selected = false;
            }
        }

        private void BTNResposta4_Click(object sender, EventArgs e)
        {
            if (BTNResposta4.BackColor == Color.FromArgb(106, 106, 106))
            {
                BTNResposta4.BackColor = Color.DodgerBlue;
                btn4Selected = true;
            }
            else
            {
                BTNResposta4.BackColor = Color.FromArgb(106, 106, 106);
                btn4Selected = false;
            }
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Por favor selecione um exame.");
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.Microsoft_Word_Logo;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.microsoft_office_excel_logo_icon_145720;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Microsoft_PowerPoint_Logo_wine;
                    break;
            }
        }
    }
}
