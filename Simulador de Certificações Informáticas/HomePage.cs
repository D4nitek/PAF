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
            label2.Text = "Bem vindo " + username + " | Nível de Acesso: " + ((level > 0) ? "Administrador" : "Utilizador");
            label3.Text = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
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
