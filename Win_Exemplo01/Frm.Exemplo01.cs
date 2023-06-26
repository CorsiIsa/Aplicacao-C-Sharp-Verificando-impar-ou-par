using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtnumero.Text);
                if (x % 2 == 0)
                {
                    MessageBox.Show("O número  " + x + " é PAR");
                }
                else
                {
                    MessageBox.Show("O número  " + x + " é IMPAR");
                }
            }

            catch(FormatException erro)
            {
                MessageBox.Show(erro.Message);
                btnCancelar_Click(sender, e);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();// Limpa o conteúdo digitado
            txtnumero.Focus();// Faz o cursor ficar intermitente
        }
    }
}
