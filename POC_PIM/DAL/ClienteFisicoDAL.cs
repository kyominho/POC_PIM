using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //DLL DE BANCO DE DADOS -> SQLCOMMAND, SQLCONNECTION, SQLDATAREADER

namespace POC_PIM.DAL
{
     class ClienteFisicoDAL
    {
        //cadastrar cliente fisico. Trazendo a classe de conexão e a classe da BLL contendo os dados.
        Conexao conexao = new Conexao();

        public void CadastrarClienteF (BLL.ClienteFisico clienteFisico)
        {
            //instanciando objeto do tipo comando sqlcommand 
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO ClienteFisico VALUES (@CpfCliente, @CodClienteF)";
            cmd.Parameters.AddWithValue("@CpfCliente", clienteFisico.CpfCliente);
            cmd.Parameters.AddWithValue("@CodClienteF", clienteFisico.CodClienteF);

            //chamando o metodo de abrir conexao com o banco
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando o metodo de fechar conexão
            conexao.Desconectar();



        }
    }
}
