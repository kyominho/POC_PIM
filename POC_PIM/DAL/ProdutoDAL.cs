using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //DLL DE CONEXÃO COM BANCO DE DADOS

namespace POC_PIM.DAL
{
    internal class ProdutoDAL
    {
        Conexao conexao = new Conexao();

        public void CadastrarProduto (BLL.Produto produto)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Produto VALUES (@NomeProduto, @PrecoProduto, @DataValidadeProduto)";
            cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@PrecoProduto", produto.PrecoProduto);
            cmd.Parameters.AddWithValue("@DataValidadeProduto", produto.DataValidadeProduto);

            //abrindo conexão com o banco. Para toda interação com o banco é necessario sua abertura.
            cmd.Connection = conexao.Conectar();

            //executando os comando com ExecuteNonQuery -> ele mostra a quantidade de linhas afetadas, ou seja, de linhas de registro incluidas, excluidas ou alteradas
            cmd.ExecuteNonQuery();

            //fechando a conexão 
            conexao.Desconectar();

        }
    }
}
