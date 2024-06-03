using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class EntregaDAL
    {
        //classe de conexão com o Banco de Dados
        Conexao conexao = new Conexao();

        public void CadastrarEntrega (BLL.Entrega entrega)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Entrega VALUES (@QuantidadeEntrega, @CodVendaE, @CodClienteE)";
            cmd.Parameters.AddWithValue("@QuantidadeEntrega", entrega.QuantidadeEntrega);
            cmd.Parameters.AddWithValue("@CodVendaE", entrega.CodVendaE);
            cmd.Parameters.AddWithValue("@CodClienteE", entrega.CodClienteE);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao 
            conexao.Desconectar();

        }
    }
}
