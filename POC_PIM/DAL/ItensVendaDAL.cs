using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class ItensVendaDAL
    {
        Conexao conexao = new Conexao();

        public void CadastrarItensVenda(BLL.ItensVenda itensVenda)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO ItensVenda VALUES (@QuantidadeItensVenda, @ValorTotalItensVenda, @CodProdutoIV, @CodVendaIV)";

            cmd.Parameters.AddWithValue("@QuantidadeItensVenda",itensVenda.QuantidadeItensVenda);
            cmd.Parameters.AddWithValue("@ValorTotalItensVenda",itensVenda.ValorTotalItensVenda);
            cmd.Parameters.AddWithValue("@CodProdutoIV", itensVenda.CodProdutoIV);
            cmd.Parameters.AddWithValue("@CodVendaIV", itensVenda.CodVendaIV);

            cmd.Connection = conexao.Conectar();

            cmd.ExecuteNonQuery();

            conexao.Desconectar();


        }
    }
}
