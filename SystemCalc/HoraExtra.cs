using System;
using System.Windows.Forms;
using System.Globalization;

namespace SystemCalc
{
    public partial class HoraExtra : Form
    {
        public HoraExtra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            Close();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = textSalario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double salario, qtd_Hora, total;

            if ((txtHoraExtra.Text == "") || (textSalario.Text == ""))
            {
                MessageBox.Show("Digite um valor");

            }
            else
            {
                qtd_Hora = Convert.ToDouble(txtHoraExtra.Text);
                salario = Convert.ToDouble(textSalario.Text);

                total = salario / 220 * 1.75 * qtd_Hora;


                lblTotal.Text = total.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
}
