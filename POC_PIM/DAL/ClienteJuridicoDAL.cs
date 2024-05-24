using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    class ClienteJuridicoDAL
    {
        //chamando classe de conexão com o banco
        Conexao conexao = new Conexao();

        public void CadastrarClienteJ (BLL.ClienteJuridico clienteJuridico)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO ClienteJuridico VALUES (@CnpjCliente, @RazaoSocialCliente, @CodClienteJ)";
            cmd.Parameters.AddWithValue("@CnpjCliente", clienteJuridico.CnpjCliente);
            cmd.Parameters.AddWithValue("@RazaoSocialCliente", clienteJuridico.RazaoSocialCliente);
            cmd.Parameters.AddWithValue("@CodClienteJ", clienteJuridico.CodClienteJ);

            //chamando o metodo de abrir conexão com o banco de dados
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexão
            conexao.Desconectar();
        }


    }
}
