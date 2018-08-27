using System;
using System.Windows.Forms;

namespace SystemCalc
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            ActiveControl = txtValor1;    // atribuindo o txtValor1 como foco principal

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();           // fechando aplicação   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Obrigado, volte sempre! ");   // mensagem
            Application.Exit();                            // fechando aplicação 
            

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;              // variaveis
            if ((txtValor1.Text == "") || (txtValor2.Text == ""))    // se valor1 e valor2 for igual a null
               {
                MessageBox.Show("Digite um valor");                  //  mostrar mensagem
               }
                else
                    {
                valor1 = Convert.ToDouble(txtValor1.Text);           // convertendo valor de String para real, e atribuindo para valor1
                valor2 = Convert.ToDouble(txtValor2.Text);           // convertendo valor de String para real, e atribuindo para valor2
                resultado = valor1 + valor2;                         // conta
                tblTotal.Text = resultado.ToString();                // Enviando resultado em formato String para tblTotal
                    }                     
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;

            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
              {
                MessageBox.Show("Digite um valor ! ");

            }
            else{
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 - valor2;
                tblTotal.Text = resultado.ToString();
            }            
         }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;

            if ((txtValor1.Text == "") || (txtValor2.Text == ""))
                {
                MessageBox.Show("Digite um valor !");
            }else{
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 / valor2;
                tblTotal.Text = resultado.ToString();            
            }                    
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;

            if((txtValor1.Text == "") || (txtValor2.Text == ""))
               {
                MessageBox.Show("Digite um valor ! ");

            }else{
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 * valor2;
                tblTotal.Text = resultado.ToString();

            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoraExtra hora = new HoraExtra();
            this.Visible = false;
            hora.Show();
        }

        private void Idade_Click(object sender, EventArgs e)
        {
            telaIdade idade = new telaIdade();
            this.Visible = false;
            idade.Show();
        }

        private void tblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
