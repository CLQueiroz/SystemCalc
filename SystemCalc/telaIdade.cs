using System;
using System.Windows.Forms;

namespace SystemCalc
{
    public partial class telaIdade : Form // projeto principal
    {
        public telaIdade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();    // estanciado tela principal
            telaPrincipal.Visible = true;                         // chamando tela principal novamente
            Close();                                              // fechando antigo formulario
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtAnoAtual.Text == "") || (txtAnoNasc.Text == "")) // se campo estiver branco
            {
                MessageBox.Show("Digite o campo");                   // digite o campo
            }
            else
            {
                int anoNasc, anoAtual, total;                      // variaveisa
                anoNasc = Convert.ToInt32(txtAnoNasc.Text);        // convertendo String em Inteiro 
                anoAtual = Convert.ToInt32(txtAnoAtual.Text);      // convertendo String em Inteiro
                total = anoAtual - anoNasc;                        // calculo
                lblTotal.Text = total.ToString();                  // resultado
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
