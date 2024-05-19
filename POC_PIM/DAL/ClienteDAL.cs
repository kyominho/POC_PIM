using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    class ClienteDAL
    {
        Conexao conexao = new Conexao();

        //cadastrar cliente. Trazendo a classe de conexão e a classe da BLL contendo os dados.
        public void CadastrarCliente (BLL.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Cliente VALUES (@NomeCliente, @EmailCliente, @UFCliente, @CidadeCliente, @TelefoneCliente, @CepCliente, @LogradouroCliente, @NumCliente )";
            cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
            cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente);
            cmd.Parameters.AddWithValue("@UFCliente", cliente.UFCliente);
            cmd.Parameters.AddWithValue("@CidadeCliente", cliente.CidadeCliente);
            cmd.Parameters.AddWithValue("@TelefoneCliente", cliente.TelefoneCliente);
            cmd.Parameters.AddWithValue("@CepCliente", cliente.CepCliente);
            cmd.Parameters.AddWithValue("@LogradouroCliente", cliente.LogradouroCliente);
            cmd.Parameters.AddWithValue("@NumCliente", cliente.NumCliente);


            //chamando o metodo de abrir conexao com o banco
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando o metodo de fechar conexão
            conexao.Desconectar();

        }

    }
}
