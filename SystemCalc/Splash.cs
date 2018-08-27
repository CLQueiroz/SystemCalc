using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemCalc
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            else
            {
                timer1.Enabled = false;                             // Finalizando tempo
                TelaLogin telaLogin = new TelaLogin();                // Estanciando tela login
                telaLogin.Show();                                   // Chamando tela de login na tela          
                this.Visible = false;                                // fechar janela anterior
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
