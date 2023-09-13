using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_hello_world : Form
    {
        public Frm_hello_world()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Txt_Email.Text == "Elvis@198" & Txt_senha.Text == "123456")
            {
                Lbl_Verificacao.Text = "Acesso Autorizado";
                Lbl_Verificacao.ForeColor = System.Drawing.Color.Green;


            } else
            {
                Lbl_Verificacao.Text = "Acesso Negado";
                Lbl_Verificacao.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
