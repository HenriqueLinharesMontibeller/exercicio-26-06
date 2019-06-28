using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    class ContaReceberRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Henrique.mdf;Integrated Security=True;Connect Timeout=30";
        
        public void Inserir(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO cotas_receber"
        }

        private void Apagar(int id)
        {

        }

        private void Alterar(ContaReceber contaReceber)
        {

        }

        public List<ContaReceber> ObterTodos(string busca)
        {

        }

        public ContaPagar ObterPeloId(int id)
        {

        }
    }
}
