using Model;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientesRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Henrique.mdf;Integrated Security=True;Connect Timeout=30";

        public void Inserir(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO clientes (nome, cpf, data_nascimento, rg) VALUES (@NOME, @CPF, @DATA_NASCIMENTO, @RG)";
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET
nome = @NOME,
cpf = @CPF,
data_nascimento = @DATA_NASCIMENTO,
rg = @RG
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Cliente> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

        }
    }
}
