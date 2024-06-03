using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class ColheitaDAL
    {
        //classe de conexão com o Banco de Dados
        Conexao conexao = new Conexao();

        public void CadastrarColheita(BLL.Colheita colheita)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Colheita VALUES (@DataHorarioColheita, @QuantidadeColheita, @CodProdutoC)";
            cmd.Parameters.AddWithValue("@DataHorarioColheita", colheita.DataHorarioColheita);
            cmd.Parameters.AddWithValue("@QuantidadeColheita", colheita.QuantidadeColheita);
            cmd.Parameters.AddWithValue("@CodProdutoC", colheita.CodProdutoC);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao 
            conexao.Desconectar();


        }
    }
}
