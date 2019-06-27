using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            ContasPagar continhaPagar = new ContasPagar();
            continhaPagar.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            ContasReceber continhasReceber = new ContasReceber();
            continhasReceber.ShowDialog();
        }
    }
}
