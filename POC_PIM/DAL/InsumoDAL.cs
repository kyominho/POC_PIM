using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
     class InsumoDAL
    {
        //classe de conexão com o BD
        Conexao conexao = new Conexao();

        public void CadastrarInsumo (BLL.Insumo insumo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Insumo VALUES (@NomeInsumo, @DataValidadeInsumo, @PrecoInsumo)";
            cmd.Parameters.AddWithValue("@NomeInsumo", insumo.NomeInsumo);
            cmd.Parameters.AddWithValue("@DataValidadeInsumo", insumo.DataValidadeInsumo);
            cmd.Parameters.AddWithValue("@PrecoInsumo", insumo.PrecoInsumo);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos 
            cmd.ExecuteNonQuery();

            //fechando conexão
            conexao.Desconectar();


        }
    }
}
