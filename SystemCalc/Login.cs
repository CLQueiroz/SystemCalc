using System;
using System.Windows.Forms;

namespace SystemCalc
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            ActiveControl = textSenha;    // atribuindo foco principal para textSenha

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();           // fechando aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textUsuario.Text == "CAIQUE") && (textSenha.Text == "123"))     // atribuindo valor aos text
                {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                MessageBox.Show("Seja bem vindo! ");
                telaPrincipal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido !", "Ocorreu um erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {         
        }
    }
}
