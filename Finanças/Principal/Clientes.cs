using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Repository;

namespace Principal
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
            LimparCampos();
            AtualizarTabela();
        }

        private void Inserir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.DataNascimento = dtpDataNascimento.Value;
            cliente.Rg = mtbRg.Text;

            ClientesRepositorio repositorio = new ClientesRepositorio();
            repositorio.Inserir(cliente);
        }

        private void Alterar()

        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.DataNascimento = dtpDataNascimento.Value;
            cliente.Rg = mtbRg.Text;

            ClientesRepositorio repositorio = new ClientesRepositorio();
            repositorio.Alterar(cliente);

        }

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            txtBuscar.Clear();
            mtbCpf.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            mtbRg.Clear();
        }

        private void AtualizarTabela()
        {
            ClientesRepositorio repositorio = new ClientesRepositorio();
            string busca = txtBuscar.Text;
            List<Cliente> clientes = repositorio.ObterTodos(busca);
            dataGridView1.RowCount = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cliente = clientes[i];
                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Id.ToString(), cliente.Nome, cliente.Cpf, cliente.DataNascimento.ToString(), cliente.Rg
                });
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quer realmente apagar?","CUIDADO", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClientesRepositorio repositorio = new ClientesRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClientesRepositorio repositorio = new ClientesRepositorio();

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente cliente = repositorio.ObterPeloId(id);
            if(cliente != null)
            {
                txtNome.Text = cliente.Nome;
                mtbCpf.Text = cliente.Cpf;
                dtpDataNascimento.Text = cliente.DataNascimento.ToString();
                mtbRg.Text = cliente.Rg;
                lblId.Text = cliente.Id.ToString();

            }
        }

        private void Clientes_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}





