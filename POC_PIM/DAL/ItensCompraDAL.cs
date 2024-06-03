using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class ItensCompraDAL
    {
        Conexao conexao = new Conexao();

        public void CadastrarItensCompra (BLL.ItensCompra itensCompra)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO ItensCompra VALUES (@QuantidadeItensCompra, @ValorTotalItensCompra, @CodInsumoIC, @CodCompraIC)";

            cmd.Parameters.AddWithValue("@QuantidadeItensCompra", itensCompra.QuantidadeItensCompra);
            cmd.Parameters.AddWithValue("@ValorTotalItensCompra", itensCompra.ValorTotalItensCompra);
            cmd.Parameters.AddWithValue("@CodInsumoIC", itensCompra.CodInsumoIC);
            cmd.Parameters.AddWithValue("@CodCompraIC", itensCompra.CodCompraIC);

            cmd.Connection = conexao.Conectar();

            cmd.ExecuteNonQuery();

            conexao.Desconectar();


        }
    }
}
