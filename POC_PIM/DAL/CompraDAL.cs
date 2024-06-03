using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class CompraDAL
    {
        Conexao conexao = new Conexao();

        public void CadastrarCompra (BLL.Compra compra)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Compra VALUES (@DataHorarioCompra, @FormaPagamentoCompra, @CodFornecedorC, @CodUsuarioC)";

            cmd.Parameters.AddWithValue("@DataHorarioCompra", compra.DataHorarioCompra);
            cmd.Parameters.AddWithValue("@FormaPagamentoCompra", compra.FormaPagamentoCompra);
            cmd.Parameters.AddWithValue("@CodFornecedorC", compra.CodFornecedorC);
            cmd.Parameters.AddWithValue("@CodUsuarioC", compra.CodUsuarioC);

            cmd.Connection = conexao.Conectar();

            cmd.ExecuteNonQuery();

            conexao.Desconectar();


        }
    }
}
