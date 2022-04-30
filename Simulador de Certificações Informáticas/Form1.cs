using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Simulador_de_Certificações_Informáticas
{
    public partial class LoginPage : Form
    {
        bool isVisible = false;

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
        public LoginPage()
        {
            InitializeComponent();
            //Faz com que fique com rounded corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isVisible == false)
            {
                isVisible = true;
                btnVisible.Image = Properties.Resources.Visible;
                TBpassword.PasswordChar = '\0';
            }
            else
            {
                isVisible = false;
                btnVisible.Image = Properties.Resources.NotVisible;
                TBpassword.PasswordChar = '●';
            }
        }

        private void TBuser_Click(object sender, EventArgs e)
        {
            if(labelUsername.Visible == false)
            {
                TBuser.Text = String.Empty;
                labelUsername.Visible = true;
            }
            else { }
        }

        private void TBpassword_Click(object sender, EventArgs e)
        {
            if(labelPassword.Visible == false)
            {
                TBpassword.Text = String.Empty;
                labelPassword.Visible = true;
            }
            else { }
        }

        //Botão de login, verifica as textbox e dá read na database
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            SQL.connection.Open();

            SQL.command.Connection = SQL.connection;
            SQL.command.CommandText = "SELECT * FROM usercredentials WHERE username = '" + TBuser.Text.Trim() + "' AND password = '" + TBpassword.Text.Trim() + "'";

            SQL.dataReader = SQL.command.ExecuteReader();

            if (SQL.dataReader.Read())
            { 
                Hide();
                Form homepage = new HomePage(TBuser.Text, SQL.dataReader.GetInt32(0), SQL.dataReader.GetInt32(3));
                SQL.connection.Close();
                homepage.ShowDialog();
            }
            labelErro.Visible = true;
            TBuser.Text = String.Empty;
            TBpassword.Text = String.Empty;
            TBuser.Focus();
            SQL.connection.Close();
        }

        private void TBuser_TextChanged(object sender, EventArgs e)
        {
            if (TBuser.Text != String.Empty)
            {
                labelErro.Visible = false;
                labelUsername.Visible = true;
            }
        }
    }
}
