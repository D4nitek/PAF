using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_de_Certificações_Informáticas
{
    public partial class LoginPage : Form
    {
        bool isVisible = false;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(isVisible == false)
                isVisible = true;
            else
            isVisible = false;

            if (isVisible == false)
            {
                pictureBox3.Image = Image.FromFile("media/NotVisible.png");
            }
            else
                pictureBox3.Image = Image.FromFile("media/Visible.png");
            
        }
    }
}
