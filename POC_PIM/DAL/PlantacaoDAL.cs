using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    public class PlantacaoDAL
    {
        //classe de conexão com o Banco de Dados
        Conexao conexao = new Conexao();

        public void CadastrarPlantacao(BLL.Plantacao plantacao)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Plantacao VALUES (@DataHorarioPlantacao, @QuantidadePlantacao, @CodInsumoP)";
            cmd.Parameters.AddWithValue("@DataHorarioPlantacao", plantacao.DataHorarioPlantacao);
            cmd.Parameters.AddWithValue("@QuantidadePlantacao", plantacao.QuantidadePlantacao);
            cmd.Parameters.AddWithValue("@CodInsumoP", plantacao.DataHorarioPlantacao);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao 
            conexao.Desconectar();


        }
    }
}
