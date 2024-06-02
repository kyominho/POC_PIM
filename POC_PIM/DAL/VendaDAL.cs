using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class VendaDAL
    {
        Conexao conexao = new Conexao ();

        public void CadastrarVenda(BLL.Venda venda)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Venda VALUES (@DataHorarioVenda, @FormaPagamentoVenda, @CodUsuarioV, @CodClienteV)";

            cmd.Parameters.AddWithValue("@DataHorarioVenda", venda.DataHorarioVenda);
            cmd.Parameters.AddWithValue("@FormaPagamentoVenda", venda.FormaPagamentoVenda);
            cmd.Parameters.AddWithValue("@CodUsuarioV", venda.CodUsuarioV);
            cmd.Parameters.AddWithValue("@CodClienteV", venda.CodClienteV);

            cmd.Connection = conexao.Conectar();

            cmd.ExecuteNonQuery();

            conexao.Desconectar();


        }
    }
}
