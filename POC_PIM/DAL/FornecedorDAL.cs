using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    class FornecedorDAL
    {
        //instanciando classe de conexão com o banco de dados
        Conexao conexao = new Conexao();

        public void CadastrarFornecedor(BLL.Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Fornecedor VALUES (@NomeFornecedor, @EmailFornecedor, @UfFornecedor, @CidadeFornecedor, @LogradouroFornecedor, @NumeroEnderecoFornecedor, @CnpjFornecedor, @RazaoSocialFornecedor)";

            cmd.Parameters.AddWithValue("@NomeFornecedor", fornecedor.NomeFornecedor);
            cmd.Parameters.AddWithValue("@EmailFornecedor", fornecedor.EmailFornecedor);
            cmd.Parameters.AddWithValue("@UfFornecedor", fornecedor.UfFornecedor);
            cmd.Parameters.AddWithValue("@CidadeFornecedor", fornecedor.CidadeFornecedor);
            cmd.Parameters.AddWithValue("@LogradouroFornecedor", fornecedor.LogradouroFornecedor);
            cmd.Parameters.AddWithValue("@NumeroEnderecoFornecedor", fornecedor.NumeroEnderecoFornecedor);
            cmd.Parameters.AddWithValue("@CnpjFornecedor", fornecedor.CnpjFornecedor);
            cmd.Parameters.AddWithValue("@RazaoSocialFornecedor", fornecedor.RazaoSocialFornecedor);

            //chamando metodo de abrir conexao
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao
            conexao.Desconectar();

        }
    }
}
