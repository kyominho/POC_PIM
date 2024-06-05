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

        public List<BLL.Cliente> GetClientes()
        {
            List<BLL.Cliente> clientes = new List<BLL.Cliente>();

            Conexao conexao = new Conexao();

            SqlCommand cmd = new SqlCommand();

            //selecionando os dados
            cmd.CommandText = @"SELECT * FROM Cliente";

            cmd.Connection = conexao.Conectar();

            //executando o comando e armazenando os resultados
            SqlDataReader reader = cmd.ExecuteReader();

            //lendo os resultados
            while (reader.Read())
            {
                BLL.Cliente cliente = new BLL.Cliente();

                cliente.NomeCliente = reader["nomeCliente"].ToString();
                cliente.EmailCliente = reader["emailCliente"].ToString();
                cliente.UFCliente = reader["ufCliente"].ToString();
                cliente.CidadeCliente = reader["cidadeCliente"].ToString();
                cliente.TelefoneCliente = reader["telefoneCliente"].ToString();
                cliente.CepCliente = reader["cepCliente"].ToString();
                cliente.LogradouroCliente = reader["logradouroCliente"].ToString();
                cliente.NumCliente = Convert.ToInt16(reader["numeroEnderecoCliente"].ToString());
     

                clientes.Add(cliente);





            }
            //fechando conexao
            conexao.Desconectar();
            return clientes;
        }

    }
}
