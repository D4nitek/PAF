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

        //Tab Simulador

        bool btn1Selected = false;
        bool btn2Selected = false;
        bool btn3Selected = false;
        bool btn4Selected = false;
        int contador = 1;
        int tabela_atual = 0;

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

        private void load_exame(int exame_escolhido, int pergunta_atual)
        {
            string table = "";

            if (exame_escolhido == 1)
            {
                tabela_atual = exame_escolhido;
                table = "word";
            }    
            else if (exame_escolhido == 2)
            {
                tabela_atual = exame_escolhido;
                table = "excel";
            }    
            else if (exame_escolhido == 3)
            {
                tabela_atual = exame_escolhido;
                table = "powerpoint";
            }
                
            SQL.connection.Open();
            SQL.command.Connection = SQL.connection;
            SQL.command.CommandText = "SELECT * FROM " + table + " WHERE idpergunta = '" + pergunta_atual + "'";
            SQL.dataReader = SQL.command.ExecuteReader();

            if (SQL.dataReader.Read())
            {
                IDPergunta.Text = SQL.dataReader.GetString(0);
                TBPergunta.Text = SQL.dataReader.GetString(1);
                TBResposta1.Text = SQL.dataReader.GetString(2);
                TBResposta2.Text = SQL.dataReader.GetString(3);
                TBResposta3.Text = SQL.dataReader.GetString(4);
                TBResposta4.Text = SQL.dataReader.GetString(5);
            }

            SQL.connection.Close();

        }

        public HomePage(string username, int level)
        {
            InitializeComponent();
            if(level > 0)
            {
                lockedPanel.Visible = false;
                lockedIcon.Visible = false;
            }
            else
            {
                lockedPanel.Visible = true;
                lockedIcon.Visible = true;
            }
                
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

        private void BTNResposta1_Click(object sender, EventArgs e)
        {
            if (BTNResposta1.BackColor == Color.FromArgb(106, 106, 106))
            {
                BTNResposta1.BackColor = Color.DodgerBlue;
                btn2Selected = true;
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

        private void BTNIniciar_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Por favor, selecione um exame.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox1.Image = Properties.Resources.Microsoft_Office_logo;
                    TBPergunta.Text = "Por favor, selecione um exame.";
                    break;
                case 1:
                    comboBox1.Enabled = false;
                    pictureBox1.Image = Properties.Resources.Microsoft_Word_Logo;
                    load_exame(1,1);
                    BTNNext.Visible = true;
                    BTNPrevious.Visible = true;
                    break;
                case 2:
                    comboBox1.Enabled = false;
                    pictureBox1.Image = Properties.Resources.microsoft_office_excel_logo_icon_145720;
                    load_exame(2,1);
                    BTNNext.Visible = true;
                    BTNPrevious.Visible = true;
                    break;
                case 3:
                    comboBox1.Enabled = false;
                    pictureBox1.Image = Properties.Resources.Microsoft_PowerPoint_Logo_wine;
                    load_exame(3,1);
                    BTNNext.Visible = true;
                    BTNPrevious.Visible = true;
                    break;
                default:
                    MessageBox.Show("Por favor, selecione um exame.","Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                    break;
            }
        }

        private void BTNPrevious_Click(object sender, EventArgs e)
        {
            if (contador > 1)
            {
                load_exame(tabela_atual, contador -= 1);
            }
            else
            {
                MessageBox.Show("Chegou á ultima pergunta!");
            }
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            if (contador >= 1 && contador < 10)
            {
                load_exame(tabela_atual, contador += 1);
            }
            else
            {
                MessageBox.Show("Chegou á ultima pergunta!");
                BTNFinish.Visible = true;
            }
        }

        private void BTNFinish_Click(object sender, EventArgs e)
        {

        }
        //Fim do código da tab Simulador
        //Tab Resultados
    }
}
