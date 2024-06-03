using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class EstoqueProdutoDAL
    {
        //classe de conexão com o Banco de Dados
        Conexao conexao = new Conexao();

        public void CadastrarEstoqueP (BLL.EstoqueProduto estoqueProduto)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO EstoqueProduto VALUES (@QuantidadeEstoqueProduto, @CodProdutoEP)";
            cmd.Parameters.AddWithValue("@QuantidadeEstoqueProduto", estoqueProduto.QuantidadeEstoqueProduto);
            cmd.Parameters.AddWithValue("@CodProdutoEP", estoqueProduto.CodProdutoEP);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao 
            conexao.Desconectar();
        }
    }
}
